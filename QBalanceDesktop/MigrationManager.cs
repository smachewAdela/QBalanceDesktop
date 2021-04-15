using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace QBalanceDesktop
{
    public class MigrationManager
    {
        static DbAccess lDb;
        private static DbAccess LocalDb
        {
            get
            {
                if (lDb == null)
                {
                    var connStr = ConfigurationManager.AppSettings["connectionString"];
                    lDb = new DbAccess(connStr);
                }
                return lDb;
            }
        }

        static DbAccess rDb;
        private static DbAccess QDb
        {
            get
            {
                if (rDb == null)
                {
                    var connStr = ConfigurationManager.AppSettings["qconnectionString"];
                    rDb = new DbAccess(connStr);
                }
                return rDb;
            }
        }

        internal static void MigrateData()
        {
            var allTransactions = LocalDb.GetData<Transaction>(new SearchParameters()).OrderBy(x => x.CreateDate).ToList();
       

            //var localDefs = LocalDb.GetData<Category>(new SearchParameters());
            //foreach (var localDef in localDefs)
            //    QDb.Insert(localDef);
            var months = GenerateMonths(allTransactions.Min(x => x.CreateDate)).ToDictionary(x => x.StartDate, x => x);

            foreach (var allTransaction in allTransactions)
            {
                var bt = new BudgetTransaction
                {
                    Amount = (int)allTransaction.Amount,
                    Date =allTransaction.CreateDate,
                    Name = allTransaction.Description,
                    BudgetCategoryId = months[allTransaction.CreateDate.FirstDayOfMonth()].BudgetCategories[allTransaction.category].Id,
                    MonthId = months[allTransaction.CreateDate.FirstDayOfMonth()].Id
                };

                QDb.Insert(bt);
            }
        }


        private static List<TrackedMonth> GenerateMonths(DateTime dateTime)
        {
            var idate = dateTime.FirstDayOfMonth();
            var months = new List<TrackedMonth>();
            while (idate <= DateTime.Now)
            {
                var tm = new TrackedMonth{ StartDate = idate };
                QDb.Insert(tm);
                tm.db = QDb;

                idate = idate.AddMonths(1);
                GenerateBudgetForMonth(tm);

                months.Add(tm);
            }

            return months; 
        }

        private static void GenerateBudgetForMonth(TrackedMonth tm)
        {
            var defaultBudgetCategories = QDb.GetData<Category>(new SearchParameters());
            var budgetCategories = defaultBudgetCategories.Select(x => new BudgetCategory
            {
                Name = x.Description,
                Amount = x.Amount,
                MonthId = tm.Id,
                Code = x.Code
                
            }).ToList();

            foreach (var bCategory in budgetCategories)
            {
                QDb.Insert(bCategory);
            }
        }
    }
}
