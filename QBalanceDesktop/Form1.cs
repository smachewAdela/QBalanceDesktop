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
        public Budget currentBudget { get; set; }

        public DbAccess Db
        {
            get
            {
                return GlobalsProviderBL.Db;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            ArrangeLocations();
            //ProfileManager.LoadProfile();

            //var items = Db.GetData<BudgetItem>(new SearchParameters());
            //var sitems = Db.GetData<Budget>(new SearchParameters());
            //var sitemsd = Db.GetData<BudgetGroup>(new SearchParameters());

            //var b = new Budget
            //{
            //    Month = new DateTime(2020,11,1)
            //};
            //Db.Insert(b);
            currentBudget = GlobalsProviderBL.CurrentBudget;

        }

        private void ArrangeLocations()
        {

            CenterToScreen();
            var delemeter = 30;
            var formWidth = this.Width;
            var formHeight = this.Height;

            
            gbActions.Location = new Point(delemeter, delemeter);
            pnlMonth.Location = new Point(gbActions.Location.X + gbActions.Width + delemeter, 5);
            btnExit.Location = new Point(formWidth - btnExit.Width - delemeter, formHeight - btnExit.Height - delemeter);

            gbMain.Location = new Point(gbActions.Location.X + gbActions.Width +  delemeter, delemeter);
            gbMain.Width = formWidth - delemeter *3 - gbActions.Width;
            gbMain.Height = formHeight - delemeter * 3 - btnExit.Height;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        private void LoadView()
        {
            lblMonthTitle.Text = currentBudget.Title;
        }

        private void LoadCombos()
        {
            //cmbAccounts.Items.Clear();
            //foreach (var acc in ProfileManager.Profile.accounts.CheckingAccounts)
            //    cmbAccounts.Items.Add(new LIstItem { Display = acc.AccountDesc, Value = acc.AccountID });

            //cmbCategoryGroups.Items.Clear();
            //foreach (var acc in ProfileManager.Profile.categoryGroups)
            //    cmbCategoryGroups.Items.Add(new LIstItem { Display = acc.GroupName, Value = acc.CatGroupID });

            //cmbCategoryTypes.Items.Clear();
            //foreach (var acc in ProfileManager.Profile.categoryTypes)
            //    cmbCategoryTypes.Items.Add(new LIstItem { Display = acc.CategoryTypeName, Value = acc.CategoryType });


            //cmbLoans.Items.Clear();
            //foreach (var acc in ProfileManager.Profile.accounts.Loans)
            //    cmbLoans.Items.Add(new LIstItem { Display = acc.AccountDesc, Value = acc.BalanceDisplay });

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
   

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            var nextM = Db.GetSingle<Budget>(new SearchParameters { BudgetDate = currentBudget.Month.AddMonths(1) });
            if (nextM != null)
            {
                currentBudget = nextM;
                LoadView();
            }
            else
            {
                MessageBox.Show("החודש הבא טרם הוגדר");
            }
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            var pre = Db.GetSingle<Budget>(new SearchParameters { BudgetDate = currentBudget.Month.AddMonths(-1) });
            if (pre != null)
            {
                currentBudget = pre;
                LoadView();
            }
            else
            {
                MessageBox.Show("החודש הקודם טרם הוגדר");
            }
        }

        private void BaseForm_Resize(object sender, EventArgs e)
        {
            ArrangeLocations();
        }
    }
}
