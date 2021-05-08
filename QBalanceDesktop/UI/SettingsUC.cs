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
    public partial class SettingsUC : UserControl
    {
        private ISettings ISettings;

        public SettingsUC() 
        {
            InitializeComponent();
            ISettings = GlobalsProviderBL.Db.GetData<ISettings>().FirstOrDefault();
            if(ISettings == null)
            {
                ISettings = new ISettings
                {
                    ShowUnbudgetedCategories = true
                };
                GlobalsProviderBL.Db.Insert(ISettings);
            }

            chkUnBudgetCats.Checked = ISettings.ShowUnbudgetedCategories;

            var groups = GlobalsProviderBL.Db.GetData<BudgetGroup>(new SearchParameters());
            foreach (var g in groups)
            {
                cmbNewCategoryGroup.Items.Add(new ListItem { Display = g.Name, Key = g.Id });
            }
        }

        private void SettingsUC_Load(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                //var del = 10;
                //this.Height = Parent.Height - del;
                //this.Width = Parent.Width - del;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            ISettings.ShowUnbudgetedCategories = chkUnBudgetCats.Checked;
            GlobalsProviderBL.Db.Update(ISettings);
        }

        private void btnGenerateMonth_Click(object sender, EventArgs e)
        {
            var newMonth = new DateTime(dtPicker.Value.Year, dtPicker.Value.Month,1);
            var existingMonth = GlobalsProviderBL.Db.GetSingle<Budget>(new SearchParameters { BudgetDate = newMonth });

            if (existingMonth == null)
            {
                existingMonth = new Budget { Month = newMonth };
                GlobalsProviderBL.Db.Insert(existingMonth);

                var currentBudget = GlobalsProviderBL.GetLatestBudget();


                foreach (var budgetItem in currentBudget.Items)
                {
                    budgetItem.BudgetId = existingMonth.Id;
                    budgetItem.StatusAmount = 0;
                    GlobalsProviderBL.Db.Insert(budgetItem);
                }

                foreach (var income in currentBudget.Incomes)
                {
                    income.BudgetId = existingMonth.Id;
                    income.Amount = 0;
                    GlobalsProviderBL.Db.Insert(income);
                }

                MessageBox.Show("Budget For Month Created Successfully !", "SUCCESS !");
            }
            else
                MessageBox.Show("Budget For Month Already Exists !", "ALERT !");
        }

        private void btnGenNewCategory_Click(object sender, EventArgs e)
        {
            if (cmbNewCategoryGroup.HasSelection())
            {
                if (txNewCategoryName.HasText())
                {
                    var newCategory = new BudgetItem {  CategoryName = txNewCategoryName.Text};
                    if (txNewCategoryBudget.HasText())
                    {
                        newCategory.BudgetAmount = txNewCategoryBudget.Parse<int>();
                    }
                    if (chkAllMonths.Checked)
                    {
                        var months = GlobalsProviderBL.Db.GetData<Budget>(new SearchParameters());
                        foreach (var m in months)
                        {
                            ValidateAndCreateCategory(newCategory, m);
                        }
                    }
                    else
                    {
                        var cMonth = GlobalsProviderBL.GetLatestBudget();
                        ValidateAndCreateCategory(newCategory, cMonth);
                    }
                    MessageBox.Show("Category Created !", "SUCCESS");
                }
                else
                    MessageBox.Show("Please Enter Category Name", "ERROR");
            }
            else
            {
                MessageBox.Show("Please Select Group", "ERROR");
            }
        }

        private static void ValidateAndCreateCategory(BudgetItem newCategory, Budget m)
        {
            if (m.Items.Any(x => x.CategoryName == newCategory.CategoryName))
            {
                MessageBox.Show("Category Already Exists For Month " + m.Title, "ERROR");
                return;
            }
            newCategory.BudgetId = m.Id;
            GlobalsProviderBL.Db.Insert(newCategory);
        }
    }
}
