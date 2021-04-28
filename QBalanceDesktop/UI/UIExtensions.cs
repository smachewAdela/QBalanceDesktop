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
    }
}
