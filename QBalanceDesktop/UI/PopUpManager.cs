using System;
using System.Drawing;
using Tulpep.NotificationWindow;

namespace QBalanceDesktop.UI
{
    internal class PopUpManager
    {
        public static void NotifySuccess(string message, string title = null)
        {
            Show(message, true, title);
        }

        public static void NotifyError(string message, string title = null)
        {
            Show(message, false, title);
        }
        private static void Show(string msg, bool success, string iTitle = null)
        {
            var iColor = success ? Color.GreenYellow : Color.DarkRed;
            var title = iTitle ?? (success ? "Success" : "Error");

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = title;
            popup.ContentText = msg;
            popup.BodyColor = Color.Black;
            popup.BorderColor = iColor;
            popup.ContentPadding = new System.Windows.Forms.Padding(10, 5, 10, 2);
            popup.HeaderColor = iColor;
            popup.ContentFont = new Font("Segoe UI", 18, FontStyle.Bold);
            popup.ContentColor = Color.WhiteSmoke;
            popup.IsRightToLeft = true;
            popup.Popup();// show 
        }

        internal static void NotifyGenericSuccess()
        {
            NotifySuccess("פעולה בוצעה בהצלחה");
        }

        internal static void NotifyInvalidInput()
        {
            NotifyError(" יש להזין ערכים תקינים ");
        }
    }
}