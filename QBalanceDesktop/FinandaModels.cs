using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QBalanceDesktop
{
    class FinandaModels
    {
    }


    public class BankTransactions 
    {
        public bool success { get; set; }
        public Transaction[] transactions { get; set; }
        public bool tableReachedMaxSize { get; set; }
        public object[] recentCategories { get; set; }
    }

    [DbEntity("DTransactions")]
    public class Transaction : BaseDbItem
    {
        [DbField()]
        public string TransID { get; set; }
        [DbField()]
        public string uid { get; set; }
   
        [DbField()]
        public string InstituteTransID { get; set; }
        [DbField()]
        public decimal CurrencyDebit { get; set; }
        [DbField()]
        public string Description { get; set; }

        [DbField()]
        public int AccountType { get; set; }

        
        [DbField()]
        public string TransType { get; set; }
        [DbField()]
        public DateTime CreateDate { get; set; }
        [DbField()]
        public string TransCurrency { get; set; }
        [DbField()]
        public string Source { get; set; }
        [DbField()]
        public decimal Credit { get; set; }
        [DbField()]
        public decimal ReportedBalance { get; set; }
        [DbField()]
        public decimal Debit { get; set; }
        [DbField()]
        public string TransValueDate { get; set; }
        [DbField()]
        public string ReferenceID { get; set; }
        [DbField()]
        public string TransDate { get; set; }
        [DbField()]
        public decimal Amount { get; set; }
        [DbField()]
        public string category { get; set; }
        [DbField()]
        public string CatDesc { get; set; }
        [DbField()]
        public string CatGroupID { get; set; }
        [DbField()]
        public string CatGroup { get; set; }
        [DbField()]
        public string AccountNumber { get; set; }
    }


    [DbEntity("Transactions")]
    public class BudgetTransaction : BaseDbItem
    {
        //[DbField()]
        //public TransactionTypeEnum TransactionType { get; set; }

        [DbField()]
        public int BudgetCategoryId { get; set; }
        [DbField()]
        public string Name { get; set; }
        [DbField()]
        public int Amount { get; set; }
        [DbField()]
        public DateTime Date { get; set; }
        [DbField()]
        public int MonthId { get; set; }
    }

    [DbEntity("Budget")]
    public class BudgetCategory : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
        [DbField()]
        public int Amount { get; set; }

        [DbField()]
        public int MonthId { get; set; }

        [DbField()]
        public string Code { get; set; }

    }

    public class BudgetCategoryGroup : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
        [DbField()]
        public int BudgetCategoryGroupType { get; set; }
    }

    public class TrackedMonth : BaseDbItem
    {
        public string Title
        {
            get { return $"{StartDate.ToString("MMMM")}-{StartDate.Year.ToString()}"; }
        }

        [DbField]
        public DateTime StartDate { get; set; }

        

        public Dictionary<string, BudgetCategory> BudgetCategories
        {
            get
            {
                var bc = this.db.GetData<BudgetCategory>(new SearchParameters { BudgetCategoryMonthId = this.Id });
                return bc.ToDictionary(x => x.Code, x=> x);
            }
        }
    }

    public class GroupMonthlyTotal : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
        [DbField()]
        public int Amount { get; set; }

        [DbField()]
        public string Month { get; set; }
    }

    public class CategoryMonthlyTotal : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
        [DbField()]
        public int Amount { get; set; }

        [DbField()]
        public string Month { get; set; }
    }
}
