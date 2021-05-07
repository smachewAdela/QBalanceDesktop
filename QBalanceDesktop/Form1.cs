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
        Status,
        Finanda
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
        private int delemeter;

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
            delemeter = 45;
            var formWidth = this.Width;
            var formHeight = this.Height;


            pnlMonth.Location = new Point( delemeter, 5);
            lblTitle.Location = new Point(this.Width /2, pnlMonth.Location.Y);
            btnExit.Location = new Point(formWidth - btnExit.Width - delemeter, formHeight - btnExit.Height - delemeter);

            gbMain.Location = new Point( delemeter, delemeter);
            gbMain.Width = formWidth - delemeter * 2;
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
            var flowWidth = delemeter;
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
                    flowWidth = cd.Width;
                    flowLayoutPanel1.Controls.Add(cd);
                }
            }

            else if (dataMode == DataModeEnum.Budget)
            {
                if (GroupColors == null)
                    LoadGroupColors();
                foreach (var item in currentBudget.Items.OrderBy(x => x.GroupId).ToList())
                {
                    var cd = new CategoryBudgetDisplay { BudgetItem = item, Index = idx++, DistinctiveItem = GroupColors.Keys.ToList().IndexOf(item.GroupId) % 2 == 0 };
                    flowWidth = cd.Width;
                    flowLayoutPanel1.Controls.Add(cd);
                }
            }
            else if (dataMode == DataModeEnum.Status)
            {
                var groups = Db.GetData<BudgetGroup>(new SearchParameters());
                foreach (var item in groups)
                {
                    var gs = new BudgetGroupStatus { Group = item.Name, Data = currentBudget.Items.Where(x => x.GroupId == item.Id).ToList() };
                    flowWidth = gs.Width;
                    flowLayoutPanel1.Controls.Add(gs);
                }

                var totalItems = new BudgetGroupStatus { Group = "סה\"כ", Data = currentBudget.Items , IsTotal = true};
                flowLayoutPanel1.Controls.Add(totalItems);
            }
            else if (dataMode == DataModeEnum.Categories)
            {
                var groups = Db.GetData<BudgetGroup>(new SearchParameters());
                foreach (var item in currentBudget.Items)
                {
                    var gs = new CategoryEdit { BudgetItem = item, Data = groups };
                    flowWidth = gs.Width;
                    flowLayoutPanel1.Controls.Add(gs);
                }
            }
            else if (dataMode == DataModeEnum.Settings)
            {
                var gc = new SettingsUC();
                flowWidth = gc.Width;
                flowLayoutPanel1.Controls.Add(gc);
            }
            else if (dataMode == DataModeEnum.Incomes)
            {
                foreach (var item in currentBudget.Incomes)
                {
                    var gs = new GenericKeyValueUC { Key = item.Name, Value = item.Amount.ToNumberFormat(), Editable = true, IdArgument = item.Id , EditAction = onEditIncome };
                    flowWidth = gs.Width;
                    flowLayoutPanel1.Controls.Add(gs);
                }

                var totalItems = new GenericKeyValueUC { Key = "סה\"כ", Value = currentBudget.Incomes.Sum(x => x.Amount).ToNumberFormat(), IsTotal = true };
                flowLayoutPanel1.Controls.Add(totalItems);
            }
            else if (dataMode == DataModeEnum.Finanda)
            {
                var gc = new FinandaSyncUC();
                flowWidth = gc.Width;
                flowLayoutPanel1.Controls.Add(gc);
            }
            else if (dataMode == DataModeEnum.Reports)
            {
                var gc = new ReportsUC();
                flowWidth = gc.Width;
                flowLayoutPanel1.Controls.Add(gc);
            }
            flowLayoutPanel1.Width = flowWidth + delemeter;
        }

        private void RefreshMonth()
        {
            currentBudget = GlobalsProviderBL.GetLatestBudget() ;
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

                foreach (var income in currentBudget.Incomes)
                {
                    income.BudgetId = nextMonthI.Id;
                    income.Amount = 0;
                    Db.Insert(income);
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
        private void btnFinanda_Click(object sender, EventArgs e)
        {
            dataMode = DataModeEnum.Finanda;
            RefreshView();
        }
    }
}
