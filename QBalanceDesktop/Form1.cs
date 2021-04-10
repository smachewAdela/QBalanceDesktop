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
            SyncManager.Sync();
            MessageBox.Show("Sync Completed !");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var items = Db.GetData<Transaction>(new SearchParameters());
            foreach (var tran in items)
            {
                Category cat = new Category
                {
                    Code = tran.category,
                    Description = tran.CatDesc,
                    GroupId = Convert.ToInt32( tran.CatGroupID)
                };
                var exs = Db.GetSingle<Category>(new SearchParameters { CategoryCode = cat.Code });
                if (exs == null)
                    Db.Insert(cat);

                var group = new CategoryGroup
                {
                    Id = cat.GroupId,
                    Name = tran.CatGroup
                };
                var gxs = Db.GetSingle<CategoryGroup>(new SearchParameters { CategoryGroupName = group.Name });
                if (gxs == null)
                    Db.Insert(group);
            }

            MessageBox.Show("Scan Completed !");
        }
    }
}
