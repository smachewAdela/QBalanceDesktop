using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QBalanceDesktop.UI
{
    public  class CategoryTreeNode : TreeNode
    {
        private ComboBox m_ComboBox = new ComboBox();
        public ComboBox ComboBox
        {
            get
            {
                this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                return this.m_ComboBox;
            }
            set
            {
                this.m_ComboBox = value;
                this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public CategoryTreeNode(string text) : base(text)
        {

        }
    }
}
