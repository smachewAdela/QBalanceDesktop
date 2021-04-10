using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace QBalanceDesktop
{
    internal class SyncManager
    {
        static DbAccess budgetDb;
        private static DbAccess Db
        {
            get
            {
                if (budgetDb == null)
                {
                    var connStr = ConfigurationManager.AppSettings["connectionString"];
                    budgetDb = new DbAccess(connStr);
                }
                return budgetDb;
            }
        }

        internal static async void Sync(string session)
        {
            SyncData syncData = new SyncData
            {
                SyncStart = DateTime.Now,
                NewTransactions = 0,
                Session = session,
                SyncEnd = DateTime.Now
            };
            Db.Insert(syncData);
            try
            {
                var Accounts = new string[] { "1073741826", "1073741925", "1073742012" };
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

        private static void SyncForAccount(SyncData syncData)
        {
            try
            {
                var startYear = Convert.ToInt32(ConfigurationManager.AppSettings["startYear"]);

                var from = new DateTime(startYear, 1, 1);
                var to = from.AddMonths(1).AddDays(-1);
                do
                {
                    
                    if (to > DateTime.Now.Date)
                        to = DateTime.Now.Date;

                    GetTrans(from, to, syncData);
                    from = from.AddMonths(1);
                    to = from.AddMonths(1).AddDays(-1);
                }
                while (to.Date <= DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                syncData.LogInfo = ex.Message;
                syncData.Success = false;
            }
        }

        private static async void GetTrans(DateTime from, DateTime to, SyncData sync)
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