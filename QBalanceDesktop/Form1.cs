using QBalanceDesktop.UI;
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

            currentBudget = GlobalsProviderBL.CurrentBudget;
        }


        private void ArrangeLocations()
        {

            CenterToScreen();
            var delemeter = 45;
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
            flowLayoutPanel1.Controls.Clear();
            lblMonthTitle.Text = currentBudget.Title;
            var idx = 1;
            foreach (var item in currentBudget.Items)
            {
                var cd = new CategoryDisplay { BudgetItem = item, Index = idx++ };
                flowLayoutPanel1.Controls.Add(cd);
            }
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

        private void btnIncrementMonth_Click(object sender, EventArgs e)
        {
            var nextMonth = currentBudget.Month.AddMonths(1);
            if (nextMonth <= DateTime.Now)
            {
                var nextMonthI = new Budget { Month = nextMonth };
                Db.Insert(nextMonthI);


                if (nextMonthI.Id > currentBudget.Id)
                {
                    foreach (var item in currentBudget.Items)
                    {
                        item.BudgetId = nextMonthI.Id;
                        item.StatusAmount = 0;
                        Db.Insert(item);
                    }
                }
            }
        }
    }
}
