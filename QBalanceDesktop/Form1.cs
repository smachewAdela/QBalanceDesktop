using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QBalanceDesktop
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            //ProfileManager.LoadProfile();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //LoadCombos();
        }

        private void LoadCombos()
        {
            cmbAccounts.Items.Clear();
            foreach (var acc in ProfileManager.Profile.accounts.CheckingAccounts)
                cmbAccounts.Items.Add(new LIstItem { Display = acc.AccountDesc, Value = acc.AccountID });

            cmbCategoryGroups.Items.Clear();
            foreach (var acc in ProfileManager.Profile.categoryGroups)
                cmbCategoryGroups.Items.Add(new LIstItem { Display = acc.GroupName, Value = acc.CatGroupID });

            cmbCategoryTypes.Items.Clear();
            foreach (var acc in ProfileManager.Profile.categoryTypes)
                cmbCategoryTypes.Items.Add(new LIstItem { Display = acc.CategoryTypeName, Value = acc.CategoryType });


            cmbLoans.Items.Clear();
            foreach (var acc in ProfileManager.Profile.accounts.Loans)
                cmbLoans.Items.Add(new LIstItem { Display = acc.AccountDesc, Value = acc.BalanceDisplay });

        }

        DbAccess budgetDb;
        public DbAccess Db
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void btnSync_Click(object sender, EventArgs e)
        {
            //SyncManager.Sync();
            MessageBox.Show("Sync Completed !");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //var items = Db.GetData<Transaction>(new SearchParameters());
            //foreach (var tran in items)
            //{
            //    var cat = new DCategory
            //    {
            //        Code = tran.category,
            //        Description = tran.CatDesc,
            //        GroupId = Convert.ToInt32( tran.CatGroupID)
            //    };
            //    var exs = Db.GetSingle<DCategory>(new SearchParameters { CategoryCode = cat.Code });
            //    if (exs == null)
            //        Db.Insert(cat);

            //    var group = new CategoryGroup
            //    {
            //        Id = cat.GroupId,
            //        Name = tran.CatGroup
            //    };
            //    var gxs = Db.GetSingle<CategoryGroup>(new SearchParameters { CategoryGroupName = group.Name });
            //    if (gxs == null)
            //        Db.Insert(group);
            //}

            //var months = Db.GetData<TrackedMonth>(new SearchParameters()).ToDictionary(x => x.StartDate, x => x);
            //foreach (var month in months)
            //{
            //    var monthTransactions = Db.GetData<Transaction>(new SearchParameters { TranFromDate = month.Value.StartDate, TranToDate = month.Value.StartDate.AddMonths(1) });
            //    if (monthTransactions.Count > 0)
            //    {
            //        var groupTrans = monthTransactions.GroupBy(x => x.CatGroupID).ToList();
            //        var catTrans = monthTransactions.GroupBy(x => x.category).ToList();

            //        foreach (var gt in groupTrans)
            //        {
            //            var catGStats = new GroupMonthlyTotal
            //            {
            //                Month = month.Value.Title,
            //                Name = gt.First().CatGroup,
            //                Amount = (int)gt.Sum(x => x.Amount)
            //            };
            //            Db.Insert(catGStats);
            //        }

            //        foreach (var catTran in catTrans)
            //        {
            //            var catGStats = new CategoryMonthlyTotal
            //            {
            //                Month = month.Value.Title,
            //                Name = catTran.First().CatDesc,
            //                Amount = (int)catTran.Sum(x => x.Amount)
            //            };
            //            Db.Insert(catGStats);
            //        }

            //    }
            //}


            MessageBox.Show("Scan Completed !");
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            //MigrationManager.MigrateData();
        }
    }
}
