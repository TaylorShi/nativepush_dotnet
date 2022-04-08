using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Register toast activator
            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;

            // If launched from a toast
            // This launch arg was specified in our WiX installer where we register the LocalServer32 exe path.
            if (ToastNotificationManagerCompat.WasCurrentProcessToastActivated())
            {
                // Our NotificationActivator code will run after this completes,
                // and will show a window if necessary.
            }

            else
            {
                // Show the window
                // In App.xaml, be sure to remove the StartupUri so that a window doesn't
                // get created by default, since we're creating windows ourselves (and sometimes we
                // don't want to create a window if handling a background activation).
                Application.Run(new MainForm());
            }
        }

        private static void ToastNotificationManagerCompat_OnActivated(ToastNotificationActivatedEventArgsCompat e)
        {

        }

    }
}
