using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace QBalanceDesktop
{
    public static class GlobalsProviderBL
    {
        static DbAccess budgetDb;
        public static DbAccess Db
        {
            get
            {
                if (budgetDb == null)
                {
#if DEBUG
                    var connStr = ConfigurationManager.AppSettings["connectionString"];
#else
                    var connStr = ConfigurationManager.AppSettings["prodconnectionString"];
#endif
                    budgetDb = new DbAccess(connStr);
                }
                return budgetDb;
            }
        }

        public static ISettings Settings
        {
            get
            {
                return Db.GetData<ISettings>().FirstOrDefault();
            }
        }

        //static Budget b;
        //public static Budget CurrentBudget
        //{
        //    get
        //    {
        //        if (b == null)
        //        {
        //            var d = DateTime.Now.Date;

        //            do
        //            {
        //                b = Db.GetSingle<Budget>(new SearchParameters { BudgetDate = d.FirstDayOfMonth() });
        //                d = d.AddMonths(-1);
        //            } 
        //            while (b==null);

        //        }
        //        return b;
        //    }
        //}

        
    }
}
