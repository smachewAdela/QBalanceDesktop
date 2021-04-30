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

        internal static async void Sync()
        {
            var dSession = Login();
            FinandaSyncLog syncData = new FinandaSyncLog
            {
                SyncStart = DateTime.Now,
                NewTransactions = 0,
                Session = dSession,
                SyncEnd = DateTime.Now
            };
            Db.Insert(syncData);

            var startYear = Convert.ToInt32(ConfigurationManager.AppSettings["startYear"]);
            var from = new DateTime(startYear, 1, 1);

            try
            {
                var Accounts = new string[] 
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
                foreach (var item in Accounts)
                {
                    syncData.Account = item;
                    SyncForAccount(syncData);
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
            Db.Update(syncData);
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

        private static void SyncForAccount(FinandaSyncLog syncData)
        {
            try
            {
                var startYear = Convert.ToInt32(ConfigurationManager.AppSettings["startYear"]);
                var monthDelemeter = Convert.ToInt32(ConfigurationManager.AppSettings["monthDelemeter"]);

                var from = new DateTime(startYear, 1, 1);
                var to = from.AddMonths(monthDelemeter);
               
                do
                {
                    
                    //if (to > DateTime.Now.Date)
                    //    to = DateTime.Now.Date;

                    GetTrans(from, to, syncData);
                    from = to;
                    to = from.AddMonths(monthDelemeter);
                }
                while (to.Date <= DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                syncData.LogInfo = ex.Message;
                syncData.Success = false;
            }
        }

        private static async void GetTrans(DateTime from, DateTime to, FinandaSyncLog sync)
        {
            try
            {
                var model = new
                {
                    session = sync.Session, // "d338776e-13c1-4ee6-b9b7-1731bc1c3980",
                    account = sync.Account, // "1073742012",
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