using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QBalanceDesktop.UI
{
    public static class UIExtensions
    {
        public static bool HasText(this TextBox tx)
        {
            return !string.IsNullOrEmpty(tx.Text);
        }

        public static T Parse<T>(this TextBox tx)
        {
            if (tx.HasText())
                return tx.Text.ChangeType<T>();

            throw new InvalidOperationException();
        }

        public static T ChangeType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }

        public static void Fill(this ComboBox cmb, List<ListItem> data, bool clear = true)
        {
            if (clear)
                cmb.Items.Clear();

            cmb.Items.AddRange(data.ToArray());
        }

        public static bool HasSelection(this ComboBox cmb)
        {
            return cmb.SelectedIndex >= 0;
        }

        public static int GetSelection(this ComboBox cmb)
        {
            if (cmb.SelectedItem is ListItem)
            {
                return (cmb.SelectedItem as ListItem).Key;
            }
            return cmb.SelectedValue.ChangeType<int>(); 
        }
    }
}
