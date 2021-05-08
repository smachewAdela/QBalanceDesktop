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
            //btnAdd.MouseHover += BtnAdd_MouseHover;
            //btnAdd.MouseLeave += BtnAdd_MouseLeave;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = this.BackColor;
        }

        private void BtnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = IColor;
        }

        private BudgetItem _bi;
        private Color _icolor;

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
                return _icolor;
            }
            set
            {
                _icolor = value;
               lblIndex.ForeColor = value;
                lblCategoryName.ForeColor = btnAdd.BackColor = value;
                //pnlDelemeter.BackColor = value;
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
                    //lblCategoryName.ForeColor = btnAdd.BackColor = value;
                };
                txAmount.BackColor = this.BackColor;
                pnlDelemeter.BackColor = this.BackColor;
            }
        }

        private void SetValues(BudgetItem value)
        {
            var completion = value.StatusAmount > 0  && value.BudgetAmount > 0 ? (value.StatusAmount * 100 / value.BudgetAmount) : 0 ;

            lblCategoryName.Text = $"{value.CategoryName} ({value.BudgetAmount.ToNumberFormat()})";
            lblStatusAmount.Text = $"{ value.StatusAmount.ToNumberFormat()}";;

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
                PopUpManager.NotifyGenericSuccess();
            }
            else
                PopUpManager.NotifyInvalidInput();
        }
    }
}
