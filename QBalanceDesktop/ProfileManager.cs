using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    public class ProfileManager
    {
        private static string _session { get; set; }
        public static ProfileData Profile { get; set; }
        private static bool Logged
        {
            get { return !string.IsNullOrEmpty(_session); }
        }
        private static void Login()
        {
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
                _session = resultJson.session.ToString();
            }
        }

        public static async void LoadProfile()
        {
            try
            {
                CheckLogged();
                var model = new
                {
                    session = _session
                };

                using (var client = new WebApiClient())
                {
                    var serializeModel = JsonConvert.SerializeObject(model);
                    var pData = await client.PostJsonAsync("https://cloud.finanda.co.il/profileInitiation", serializeModel);
                    Profile = (ProfileData)JsonConvert.DeserializeObject(pData, typeof(ProfileData), new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void CheckLogged()
        {
            if (!Logged)
            {
                Login();
            }
        }
    }


    public class ProfileData
    {
        public bool success { get; set; }
        public Accounts accounts { get; set; }
        public Totalworth totalWorth { get; set; }
        public User user { get; set; }
        public Category[] categories { get; set; }
        public Categorygroup[] categoryGroups { get; set; }
        public Categorytype[] categoryTypes { get; set; }
        public Appconstants appConstants { get; set; }
        public Institutionsarray[] institutionsArray { get; set; }
        public Basicanalysis basicAnalysis { get; set; }
    }

    public class Accounts
    {
        public Checkingaccount[] CheckingAccounts { get; set; }
        public Loan[] Loans { get; set; }
        public Savingsandinvestment[] SavingsAndInvestments { get; set; }
        public object[] ClosedSavings { get; set; }
        public object[] ClosedLoans { get; set; }
        public object[] ClosedInvestments { get; set; }
    }

    public class Checkingaccount
    {
        public string AccountID { get; set; }
        public string AccountDesc { get; set; }
        public string AccountType { get; set; }
        public int account_type { get; set; }
        public float BalanceDisplay { get; set; }
        public string Currency { get; set; }
        public Transaction[] Transactions { get; set; }
        public Monthlytotal[] MonthlyTotals { get; set; }
        public bool tableReachedMaxSize { get; set; }
        public string _transactions_start_date { get; set; }
        public string _transactions_end_date { get; set; }
        public string AccountNum { get; set; }
        public string institute_code { get; set; }
        public string logoImagePrefix { get; set; }
        public string AccountActive { get; set; }
        public string AccountName { get; set; }
        public DateTime DownloadStamp { get; set; }
        public string ClientType { get; set; }
        public string LastCollectionSource { get; set; }
        public string Branch { get; set; }
        public string CreditLimit { get; set; }
        public string[] LinkedAccounts { get; set; }
        public string showFailureFlag { get; set; }
        public string dpid { get; set; }
        public string jobIDForError { get; set; }
        public string DoNotUpdate { get; set; }
        public string DownloadStampDayOnly { get; set; }
        public float BankBalance { get; set; }
        public string CurrentMonth { get; set; }
        public Historicaldata[] HistoricalData { get; set; }
        public string _historical_start_date { get; set; }
        public string _historical_end_date { get; set; }
        public string LinkedBank { get; set; }
        public string LinkedBranch { get; set; }
        public string LinkedAccount { get; set; }
        public string CardType { get; set; }
        public string next_ils_billing_date { get; set; }
        public int next_usd_billing_sum { get; set; }
        public string next_usd_billing_date { get; set; }
        public int next_eur_billing_sum { get; set; }
        public string next_eur_billing_date { get; set; }
        public string CreditAvailable { get; set; }
        public string card_expiration_month { get; set; }
        public string cardStatus { get; set; }
        public bool isFutureBilling { get; set; }
        public string CardCompany { get; set; }
        public int debit_day { get; set; }
        public string is_issued_by_bank { get; set; }
        public int LastReportedBalance { get; set; }
        public DateTime ChangeDate { get; set; }
        public Dailyinout[] DailyInOut { get; set; }
        public string[] recentCategories { get; set; }
    }

    public class Monthlytotal
    {
        public string Month { get; set; }
        public float Amount { get; set; }
        public float Expense { get; set; }
        public float Income { get; set; }
        public float ToSavings { get; set; }
        public string Message { get; set; }
    }

    public class Historicaldata
    {
        public string ValueDate { get; set; }
        public float Value { get; set; }
        public string Title { get; set; }
    }

    public class Dailyinout
    {
        public string Day { get; set; }
        public string Title { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
    }

    public class Loan
    {
        public string AccountID { get; set; }
        public string AccountDesc { get; set; }
        public string AccountType { get; set; }
        public int account_type { get; set; }
        public float BalanceDisplay { get; set; }
        public float PreviousPaymentSum { get; set; }
        public int LoanTotal { get; set; }
        public float UpcomingPaymentSum { get; set; }
        public float PrincipalBalance { get; set; }
        public string Currency { get; set; }
        public string UpcomingPaymentDate { get; set; }
        public string PreviousPaymentDate { get; set; }
        public string AccountNum { get; set; }
        public string institute_code { get; set; }
        public string logoImagePrefix { get; set; }
        public string AccountActive { get; set; }
        public string AccountName { get; set; }
        public DateTime DownloadStamp { get; set; }
        public string LastCollectionSource { get; set; }
        public string ParentAccount { get; set; }
        public string[] LinkedAccounts { get; set; }
        public string dpid { get; set; }
        public string DoNotUpdate { get; set; }
        public string DownloadStampDayOnly { get; set; }
        public float Balance { get; set; }
        public string LoanType { get; set; }
        public string InterestRate { get; set; }
        public string LinkageType { get; set; }
        public string InterestType { get; set; }
        public string LoanInstituteID { get; set; }
        public string OriginationDate { get; set; }
        public float EarlyTerminationFee { get; set; }
        public string EndDate { get; set; }
        public string PaymentDateDescription { get; set; }
        public string RemainingTime { get; set; }
        public object[] SubLoans { get; set; }
    }

    public class Savingsandinvestment
    {
        public string AccountID { get; set; }
        public string AccountDesc { get; set; }
        public string AccountType { get; set; }
        public int account_type { get; set; }
        public float BalanceDisplay { get; set; }
        public string Currency { get; set; }
        public float PrincipalBalance { get; set; }
        public string AccountNum { get; set; }
        public string institute_code { get; set; }
        public string logoImagePrefix { get; set; }
        public string AccountActive { get; set; }
        public string AccountName { get; set; }
        public DateTime DownloadStamp { get; set; }
        public string InstituteDesc { get; set; }
        public string LastCollectionSource { get; set; }
        public string ParentAccount { get; set; }
        public string[] LinkedAccounts { get; set; }
        public string dpid { get; set; }
        public string DoNotUpdate { get; set; }
        public string DownloadStampDayOnly { get; set; }
        public float Value { get; set; }
        public float ExpectedEndValue { get; set; }
        public string ValueDate { get; set; }
        public string InterestType { get; set; }
        public string AdjustedInterestRate { get; set; }
        public string InterestDescription { get; set; }
        public string OriginationDate { get; set; }
        public string SavingType { get; set; }
        public string SavingInstituteID { get; set; }
        public string EndDate { get; set; }
        public float UpcomingExitValue { get; set; }
        public string UpcomingExitDate { get; set; }
    }

    public class Totalworth
    {
        public Asset[] assets { get; set; }
        public Liability[] liabilities { get; set; }
        public string[] order { get; set; }
        public float totalAssets { get; set; }
        public float totalLiabilities { get; set; }
        public float total { get; set; }
    }

    public class Asset
    {
        public string title { get; set; }
        public float amount { get; set; }
        public string id { get; set; }
        public int count { get; set; }
        public int overdraft_count { get; set; }
        public int low_balance_count { get; set; }
        public string type { get; set; }
        public string notification { get; set; }
        public bool has_upcoming_exit_date { get; set; }
        public bool has_upcoming_end_date { get; set; }
    }

    public class Liability
    {
        public string title { get; set; }
        public float amount { get; set; }
        public string id { get; set; }
        public int count { get; set; }
        public bool has_upcoming_payment { get; set; }
        public string upcoming_payment_date { get; set; }
        public string type { get; set; }
        public int totalMonthlyPayment { get; set; }
        public bool has_upcoming_exit_date { get; set; }
        public bool has_upcoming_end_date { get; set; }
    }

    public class User
    {
        public string default_budget { get; set; }
        public string walletBehavior { get; set; }
        public string cid { get; set; }
        public string[] recentHashtags { get; set; }
        public string[] hashtagList { get; set; }
        public object[] recentSearches { get; set; }
        public object[] recentCategoryGroups { get; set; }
        public object[] recommendedTags { get; set; }
        public object[] jobNotifications { get; set; }
        public Insightnotification[] insightNotifications { get; set; }
        public string default_budget_name { get; set; }
        public int monthsDownloaded { get; set; }
        public string[] suggestedCategories { get; set; }
        public int totalLast30DaysWithdrawalsSum { get; set; }
        public string existingCashTransferTransactions { get; set; }
        public object[] recentTransactions { get; set; }
        public bool emptyBudget { get; set; }
        public int maxImportantNotifications { get; set; }
    }

    public class Insightnotification
    {
        public string type { get; set; }
        public string title { get; set; }
        public string key { get; set; }
        public string gaKey { get; set; }
        public string content { get; set; }
        public string displayLocation { get; set; }
        public string action { get; set; }
        public int displayModulo { get; set; }
        public int displayCounter { get; set; }
        public string source { get; set; }
        public string userType { get; set; }
        public string image { get; set; }
        public string priority { get; set; }
    }

    public class Appconstants
    {
        public string currentMonth { get; set; }
        public int monthCutoffDay { get; set; }
    }

    public class Basicanalysis
    {
        public Monthbucket[] monthBuckets { get; set; }
        public Expensesdetail[] expensesDetail { get; set; }
        public string expensesDetailsTitle { get; set; }
        public object[] popularHashtags { get; set; }
        public int currentMonthCommissions { get; set; }
        public string currentTagsTitle { get; set; }
        public Groupedtransactionbucket[] groupedTransactionBuckets { get; set; }
        public string currentExpensesMonth { get; set; }
    }

    public class Monthbucket
    {
        public string data { get; set; }
        public string title { get; set; }
        public int[] personalAnalysis { get; set; }
        public float[] incomeExpense { get; set; }
        public int counter { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class Expensesdetail
    {
        public string CatGroupID { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public string[] Transactions { get; set; }
    }

    public class Groupedtransactionbucket
    {
        public string Title { get; set; }
        public string[] CategoryList { get; set; }
        public string id { get; set; }
        public Link link { get; set; }
    }

    public class Link
    {
        public bool display { get; set; }
        public string title { get; set; }
        public string target { get; set; }
        public Targetparm targetParm { get; set; }
    }

    public class Targetparm
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Category
    {
        public string CategoryType { get; set; }
        public string CategoryGroup { get; set; }
        public string CatID { get; set; }

        [JsonProperty("Category")]
        public string CategoryName { get; set; }
        public string GroupName { get; set; }
    }

    public class Categorygroup
    {
        public string CatGroupID { get; set; }
        public string GroupName { get; set; }
        public string[] CategoryTypes { get; set; }
        public string ClassName { get; set; }
        public string color { get; set; }
        public string Src { get; set; }
    }

    public class Categorytype
    {
        public string CategoryTypeName { get; set; }
        public string CategoryType { get; set; }
    }

    public class Institutionsarray
    {
        public string instituteCode { get; set; }
        public string instituteType { get; set; }
        public string instituteTypeDescription { get; set; }
        public string oldBankID { get; set; }
        public string instituteDescription { get; set; }
        public string instituteDescriptionForDisplay { get; set; }
        public string logoImagePrefix { get; set; }
        public string credentialsHelp { get; set; }
        public Parameter[] parameters { get; set; }
    }

    public class Parameter
    {
        public string elementID { get; set; }
        public string label { get; set; }
        public int maxLength { get; set; }
        public int position { get; set; }
        public string parameterName { get; set; }
    }

}
