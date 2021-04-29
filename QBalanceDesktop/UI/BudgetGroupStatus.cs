using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace QBalanceDesktop.UI
{
    public partial class BudgetGroupStatus : UserControl
    {
        public BudgetGroupStatus()
        {
            InitializeComponent();
        }

        public string Group
        {
            get
            {
                return "" ;
            }
            set
            {
                lblName.Text = value;
            }
        }
        public List<BudgetItem> Data
        {
            get
            {
                return new List<BudgetItem>() ;
            }
            set
            {
                if (value != null)
                {
                    var budget = value.Sum(g => g.BudgetAmount);
                    lblBudget.Text = budget.ToNumberFormat();
                    var status = value.Sum(g => g.StatusAmount);
                    lblStatus.Text = status.ToNumberFormat();
                }
            }
        }

        public bool IsTotal
        {
            get
            {
                return false;
            }
            set
            {
                if (value)
                {
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.WhiteSmoke;
                }
            }
        }
    }
}
