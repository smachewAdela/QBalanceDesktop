using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QBalanceDesktop.UI
{
    public partial class GenericKeyValueUC : UserControl
    {
        public GenericKeyValueUC()
        {
            InitializeComponent();
        }

        bool edt;
        public bool Editable
        {
            get
            {
                return edt;
            }
            set
            {
                edt = value;
                btnEdit.Enabled = txValue.Enabled = value;
            }
        }
        public string Key
        {
            get
            {
                return string.Empty;
            }
            set
            {
                lblKey.Text = value;
            }
        }

        public string Value
        {
            get
            {
                return string.Empty;
            }
            set
            {
                txValue.Text = value;
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
                    this.BorderStyle = BorderStyle.None;
                    lblKey.ForeColor = txValue.ForeColor = Color.DarkOrange;
                }
            }
        }

        public int IdArgument { get; internal set; }
        public Action<int, object> EditAction { get; internal set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Editable && txValue.HasText())
            {
                EditAction(IdArgument, txValue.Parse<int>());
            }
        }

        private void lblKey_Click(object sender, EventArgs e)
        {

        }
    }
}
