using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

namespace QBalanceDesktop
{
    internal class SyncManager
    {
        private static DbAccess Db
        {
            get
            {
                return GlobalsProviderBL.Db;
            }
        }

        private static int startYear
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["startYear"]);
            }
        }

        private static int monthDelemeter
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["monthDelemeter"]);
            }
        }

        private static string[] accountsToSync
        {
            get
            {
                return new string[]
                {   "1073741826",
                    "1073741925",
                    "1073742012" ,
                    "1073741832",
                    "1073742130",
                    "1073742103",
                    "1073741828",
                    "1073741834",
                    "1073741833",
                    "1073742199"
                };
            }
        }

        private static string Login()
        {
            string session = string.Empty;
            using (var client = new GZipWebClient())
            {
                client.Headers.Add("User-Agent: Other");
                var reqparm = new System.Collections.Specialized.NameValueCollection();

                reqparm.Add("password", "nsf120315");
                reqparm.Add("device", "PostMan");
                reqparm.Add("version", "1.63");
                reqparm.Add("appVersion", "1.4");
                reqparm.Add("tzOffset", "-180");
                reqparm.Add("model", "desktop-Win32");
                reqparm.Add("checkSubscription", "true");
                reqparm.Add("userid", "samadela@gmail.com");
                byte[] responsebytes = client.UploadValues("https://cloud.finanda.co.il/login", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);

                dynamic resultJson = JObject.Parse(responsebody);
                session = resultJson.session.ToString();
            }

            return session;
        }

        internal static  void Sync()
        {
            var dSession = Login();
            DateTime from, to;
            
            CheckSyncStart(out from, out to);

            FinandaSyncLog syncData = new FinandaSyncLog
            {
                SyncStart = DateTime.Now,
                NewTransactions = 0,
                SyncEnd = DateTime.Now,
                TransactionsFromDate = from,
                TransactionsToDate = to
            };
           

            try
            {
                foreach (var accountToSync in accountsToSync)
                {
                    CheckSyncStart(out from, out to);
                    while (from.Date <= DateTime.Now.Date)
                    {
                        RetriveTransactions(from, to, dSession, accountToSync, syncData);
                        from = to;
                        to = from.AddMonths(monthDelemeter);
                    }
                }

                syncData.LogInfo = "SUCCESS";
                syncData.Success = true;
            }
            catch (Exception ex)
            {
                syncData.LogInfo = ex.Message;
                syncData.Success = false;
            }
            syncData.SyncEnd = DateTime.Now;
            if(syncData.Id == 0)
                Db.Insert(syncData);
            else
                Db.Update(syncData);
        }

        private static void CheckSyncStart(out DateTime from, out DateTime to)
        {
            from = new DateTime(startYear, 1, 1);
            var lastSync = Db.GetData<FinandaSyncLog>().OrderByDescending(x => x.SyncEnd).FirstOrDefault();
            if (lastSync != null)
                from = lastSync.SyncEnd;


            to = from.AddMonths(monthDelemeter);
        }

        private static async void RetriveTransactions(DateTime from, DateTime to, string session, string account, FinandaSyncLog sync)
        {
            try
            {
                var model = new
                {
                    session = session, // "d338776e-13c1-4ee6-b9b7-1731bc1c3980",
                    account = account, // "1073742012",
                    startDate = from.Date.ToFormatedDate() ,// "2019-04-10",
                    endDate = to.Date.ToFormatedDate()// "2021-04-10"
                };

                using (var client = new WebApiClient())
                {
                    var serializeModel = JsonConvert.SerializeObject(model);
                    var responseBankTransactions = await client.PostJsonWithModelAsync<BankTransactions>("https://cloud.finanda.co.il/getTransactionsInRange", serializeModel);
                    var cnt = responseBankTransactions.transactions.Length;
                    if (responseBankTransactions != null && responseBankTransactions.transactions != null)
                    {
                        foreach (var bankTransaction in responseBankTransactions.transactions)
                        {
                            var exs = Db.GetSingle<Transaction>(new SearchParameters { TransID = bankTransaction.TransID });
                            if (exs == null)
                            {
                                Db.Insert(bankTransaction);
                                sync.NewTransactions++;

                                if (bankTransaction.CreateDate >= sync.TransactionsToDate)
                                    sync.TransactionsToDate = bankTransaction.CreateDate;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}