using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QBalanceDesktop.UI
{
    public partial class CategoryBudgetDisplay : UserControl
    {
        public CategoryBudgetDisplay()
        {
            InitializeComponent();
            btnUpdate.MouseHover += BtnUpdate_MouseHover; 
            btnUpdate.MouseLeave += BtnUpdate_MouseLeave;
        }

        private BudgetItem _bi;

        public BudgetItem BudgetItem
        {
            get
            {
                return this._bi;
            }
            set
            {
                this._bi = value;
                SetValues(value);
            }
        }
        public int Index
        {
            get
            {
                return 0;
            }
            set
            {
                lblIndex.Text = value.ToString();
            }
        }


        public bool DistinctiveItem
        {
            get
            {
                return false;
            }
            set
            {
                if (value)
                {
                    //this.BackColor = SystemColors.ControlDark;
                    //pnlDelemeter.BackColor = SystemColors.ControlDarkDark;
                };
                //txAmount.BackColor = this.BackColor;
            }
        }

        private void SetValues(BudgetItem value)
        {
            var completion = value.StatusAmount > 0 && value.BudgetAmount > 0 ? (value.StatusAmount * 100 / value.BudgetAmount) : 0;
            lblName.Text = $"{value.CategoryName} ({completion}%)";
            txAmount.Text = $"{ value.BudgetAmount}"; ;

            if (value.StatusAmount >= value.BudgetAmount)
            {
                lblName.ForeColor = Color.DarkRed;
            }
        }


        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = SystemColors.ControlDarkDark;
        }

        private void BtnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Beige;
        }

        private void CategoryBudgetDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txAmount.HasText())
            {
                _bi.BudgetAmount += txAmount.Parse<int>();
                GlobalsProviderBL.Db.Update(_bi);
                SetValues(_bi);
            }
        }
    }
}
