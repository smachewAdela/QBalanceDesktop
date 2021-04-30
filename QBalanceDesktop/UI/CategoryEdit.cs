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
    public partial class CategoryEdit : UserControl
    {
        public CategoryEdit()
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
                lblName.Text = value.CategoryName;
            }
        }

        public List<BudgetGroup> Data
        {
            get
            {
                return null;
            }
            set
            {
                cmbGroups.DisplayMember = "Display";
                cmbGroups.ValueMember = "Key";
                
                cmbGroups.Fill(value.Select(g => new ListItem { Display = "   " +  g.Name, Key = g.Id }).ToList());
                cmbGroups.SelectedIndex = value.FindIndex(x => x.Id == _bi.GroupId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
