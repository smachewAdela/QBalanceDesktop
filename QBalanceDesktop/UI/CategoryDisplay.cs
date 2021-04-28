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

        private void SetValues(BudgetItem value)
        {
            lblCategoryName.Text = $"{value.CategoryName} [{value.BudgetAmount}]";
            lblStatusAmount.Text = value.StatusAmount.ToString();
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
