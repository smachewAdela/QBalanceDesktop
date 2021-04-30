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
    public enum DataModeEnum
    {

        Incomes,
        Budget,
        Transactions,
        Settings,
        Categories,
        Reports,
        Status
    }
    public partial class BaseForm : Form
    {
        public Budget currentBudget { get; set; }
        public Dictionary<int, Color> GroupColors { get; set; }
        public DbAccess Db
        {
            get
            {
                return GlobalsProviderBL.Db;
            }
        }
        private Random rnd = new Random();

        DataModeEnum dm;
        private DataModeEnum dataMode
        {
            get
            {
                return this.dm;
            }
            set
            {
                this.dm = value;
                lblTitle.Text = value.Translate();
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            ArrangeLocations();
           
           
            dataMode = DataModeEnum.Status;
            RefreshView(true);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
          
        }

        private void ArrangeLocations()
        {
            CenterToScreen();
            var delemeter = 45;
            var formWidth = this.Width;
            var formHeight = this.Height;


            gbActions.Location = new Point(delemeter, delemeter);
            pnlMonth.Location = new Point(gbActions.Location.X + gbActions.Width + delemeter, 5);
            lblTitle.Location = new Point(pnlMonth.Location.X + pnlMonth.Width + delemeter, pnlMonth.Location.Y);
            btnExit.Location = new Point(formWidth - btnExit.Width - delemeter, formHeight - btnExit.Height - delemeter);

            gbMain.Location = new Point(gbActions.Location.X + gbActions.Width + delemeter, delemeter);
            gbMain.Width = formWidth - delemeter * 3 - gbActions.Width;
            gbMain.Height = formHeight - delemeter * 3 - btnExit.Height;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BaseForm_Resize(object sender, EventArgs e)
        {
            ArrangeLocations();
        }
        private void LoadGroupColors()
        {
            GroupColors = new Dictionary<int, Color>();
            var groups = Db.GetData<BudgetGroup>(new SearchParameters());
            foreach (var item in groups)
            {
                GroupColors.Add(item.Id, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            }
        }

        private void RefreshView(bool refreshMonth = false)
        {
            if (refreshMonth)
            {
                RefreshMonth();
            }
            flowLayoutPanel1.Controls.Clear();
            lblMonthTitle.Text = currentBudget.Title;
            var idx = 1;

            if (dataMode == DataModeEnum.Transactions)
            {
                if (GroupColors == null)
                    LoadGroupColors();

                var hideUnbudgeted = !GlobalsProviderBL.Settings.ShowUnbudgetedCategories;

                foreach (var item in currentBudget.Items.OrderBy(x => x.GroupId).ToList())
                {
                    if (hideUnbudgeted && item.BudgetAmount == 0)
                        continue;
                    var cd = new CategoryDisplay { BudgetItem = item, Index = idx++, IColor = GroupColors[item.GroupId], DistinctiveItem = GroupColors.Keys.ToList().IndexOf(item.GroupId) % 2 == 0 };
                    flowLayoutPanel1.Controls.Add(cd);
                }
            }

            if (dataMode == DataModeEnum.Budget)
            {
                if (GroupColors == null)
                    LoadGroupColors();
                foreach (var item in currentBudget.Items.OrderBy(x => x.GroupId).ToList())
                {
                    var cd = new CategoryBudgetDisplay { BudgetItem = item, Index = idx++, DistinctiveItem = GroupColors.Keys.ToList().IndexOf(item.GroupId) % 2 == 0 };
                    flowLayoutPanel1.Controls.Add(cd);
                }
            }
            if (dataMode == DataModeEnum.Status)
            {
                var groups = Db.GetData<BudgetGroup>(new SearchParameters());
                foreach (var item in groups)
                {
                    var gs = new BudgetGroupStatus { Group = item.Name, Data = currentBudget.Items.Where(x => x.GroupId == item.Id).ToList() };
                    flowLayoutPanel1.Controls.Add(gs);
                }

                var totalItems = new BudgetGroupStatus { Group = "סה\"כ", Data = currentBudget.Items , IsTotal = true};
                flowLayoutPanel1.Controls.Add(totalItems);
            }
            if (dataMode == DataModeEnum.Categories)
            {
                var groups = Db.GetData<BudgetGroup>(new SearchParameters());
                foreach (var item in currentBudget.Items)
                {
                    var gs = new CategoryEdit { BudgetItem = item, Data = groups };
                    flowLayoutPanel1.Controls.Add(gs);
                }
            }
            if (dataMode == DataModeEnum.Settings)
            {
                flowLayoutPanel1.Controls.Add(new SettingsUC {  });
            }
            if (dataMode == DataModeEnum.Incomes)
            {
                foreach (var item in currentBudget.Incomes)
                {
                    var gs = new GenericKeyValueUC { Key = item.Name, Value = item.Amount.ToNumberFormat(), Editable = true, IdArgument = item.Id , EditAction = onEditIncome };
                    flowLayoutPanel1.Controls.Add(gs);
                }

                var totalItems = new GenericKeyValueUC { Key = "סה\"כ", Value = currentBudget.Incomes.Sum(x => x.Amount).ToNumberFormat(), IsTotal = true };
                flowLayoutPanel1.Controls.Add(totalItems);
            }
        }

        private void RefreshMonth()
        {
            var d = DateTime.Now.Date;
            Budget b = null;
            do
            {
                b = Db.GetSingle<Budget>(new SearchParameters { BudgetDate = d.FirstDayOfMonth() });
                d = d.AddMonths(-1);
            }
            while (b == null);

            currentBudget = b;
        }

        public void onEditIncome(int idArg, object newValue)
        {
            var inc = Db.GetSingle<BudgetIncomeItem>(new SearchParameters { BudgetIncomeId = idArg });
            inc.Amount = (int)newValue;
            Db.Update(inc);
            RefreshView(true);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            var nextM = Db.GetSingle<Budget>(new SearchParameters { BudgetDate = currentBudget.Month.AddMonths(1) });
            if (nextM != null)
            {
                currentBudget = nextM;
                LoadGroupColors();
                RefreshView();
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
                LoadGroupColors();
                RefreshView();
            }
            else
            {
                MessageBox.Show("החודש הקודם טרם הוגדר");
            }
        }

        private void btnIncrementMonth_Click(object sender, EventArgs e)
        {
           IncrementMonth();
        }
        private void IncrementMonth()
        {
            var nextMonth = currentBudget.Month.AddMonths(1);
            if (nextMonth <= DateTime.Now)
            {
                var nextMonthI = new Budget { Month = nextMonth };
                Db.Insert(nextMonthI);

                foreach (var budgetItem in currentBudget.Items)
                {
                    budgetItem.BudgetId = nextMonthI.Id;
                    budgetItem.StatusAmount = 0;
                    Db.Insert(budgetItem);
                }
            }
        }
        private void btnNavBudget_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Budget;
            RefreshView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Categories;
            RefreshView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Incomes;
            RefreshView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Reports;
            RefreshView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Settings;
            RefreshView();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Transactions;
            RefreshView();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Status;
            RefreshView();
        }
    }
}
