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
        }

        private void SettingsUC_Load(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                var del = 10;
                this.Height = Parent.Height - del;
                this.Width = Parent.Width - del;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            ISettings.ShowUnbudgetedCategories = chkUnBudgetCats.Checked;
            GlobalsProviderBL.Db.Update(ISettings);
        }
    }
}
