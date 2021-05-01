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
    public partial class FinandaSyncUC : UserControl
    {
        public FinandaSyncUC()
        {
            InitializeComponent();
            var lastSync = GlobalsProviderBL.Db.GetData<FinandaSyncLog>().OrderByDescending(x => x.SyncEnd).FirstOrDefault();
            var msg = "סנכרון אחרון בוצע ב :";
            if (lastSync != null)
            {
                msg += lastSync.SyncEnd.ToString();
                msg += $"   ונוספו {lastSync.NewTransactions} רשומות";
            }
            lblLastSync.Text = msg;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SyncManager.Sync();
        }
    }
}
