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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            var items = Db.GetData<SyncData>(new SearchParameters());
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        DbAccess budgetDb;
        public DbAccess Db
        {
            get
            {
                if (budgetDb == null)
                {
                    var connStr = ConfigurationManager.AppSettings["connectionString"];
                    budgetDb = new DbAccess(connStr);
                }
                return budgetDb;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SyncManager.Sync(txSession.Text);
        }
    }
}
