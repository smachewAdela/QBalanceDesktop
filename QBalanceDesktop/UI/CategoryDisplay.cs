using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QBalanceDesktop.UI
{
    public partial class CategoryDisplay : UserControl
    {
        public CategoryDisplay()
        {
            InitializeComponent();
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
                return 0 ;
            }
            set
            {
                lblIndex.Text = value.ToString();
            }
        }

        public Color IColor
        {
            get
            {
                return pnlIndex.BackColor;
            }
            set
            {
               lblIndex.ForeColor = 
                pnlDelemeter.BackColor = value;
            }
        }

        private void SetValues(BudgetItem value)
        {
            var completion = value.StatusAmount > 0  && value.BudgetAmount > 0 ? (value.StatusAmount * 100 / value.BudgetAmount) : 0 ;
            lblCategoryName.Text = $"{value.CategoryName} ({completion}%)";
            lblStatusAmount.Text = $"{ value.StatusAmount}";;

            if (value.StatusAmount >= value.BudgetAmount)
            {
                lblStatusAmount.ForeColor = Color.DarkRed;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txAmount.HasText())
            {
                _bi.StatusAmount += txAmount.Parse<int>();
                GlobalsProviderBL.Db.Update(_bi);
                SetValues(_bi);
                txAmount.Text = string.Empty;
            }
        }
    }
}
