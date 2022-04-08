using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Windows.UI.Notifications;

namespace ExampleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btn_PostPush_Click(object sender, EventArgs e)
        {
            var v = new Windows.Data.Xml.Dom.XmlDocument();
            try
            {
                v.LoadXml(rtb_PushXml.Text);
            }
            catch (Exception ex)
            {

            }
            if (v != null)
            {
                // Create the toast notification
                var toastNotif = new ToastNotification(v);

                // And send the notification
                try
                {
                    ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
                }
                catch (Exception)
                {
                    //ToastNotificationManager.CreateToastNotifier("Chrome").Show(toastNotif);
                }
            }
        }

        private static bool _hasPerformedCleanup;
        private static async Task<string> DownloadImageToDisk(string httpImage)
        {
            // Toasts can live for up to 3 days, so we cache images for up to 3 days.
            // Note that this is a very simple cache that doesn't account for space usage, so
            // this could easily consume a lot of space within the span of 3 days.

            try
            {
                if (ToastNotificationManagerCompat.CanUseHttpImages)
                {
                    return httpImage;
                }

                var directory = Directory.CreateDirectory(System.IO.Path.GetTempPath() + "WindowsNotifications.DesktopToasts.Images");

                if (!_hasPerformedCleanup)
                {
                    // First time we run, we'll perform cleanup of old images
                    _hasPerformedCleanup = true;

                    foreach (var d in directory.EnumerateDirectories())
                    {
                        if (d.CreationTimeUtc.Date < DateTime.UtcNow.Date.AddDays(-3))
                        {
                            d.Delete(true);
                        }
                    }
                }

                var dayDirectory = directory.CreateSubdirectory(DateTime.UtcNow.Day.ToString());
                string imagePath = dayDirectory.FullName + "\\" + (uint)httpImage.GetHashCode();

                if (File.Exists(imagePath))
                {
                    return imagePath;
                }

                HttpClient c = new HttpClient();
                using (var stream = await c.GetStreamAsync(httpImage))
                {
                    using (var fileStream = File.OpenWrite(imagePath))
                    {
                        stream.CopyTo(fileStream);
                    }
                }

                return imagePath;
            }
            catch { return ""; }
        }

        private void btn_ClearPush_Click(object sender, EventArgs e)
        {

        }

        private async void btn_PrevPush_Click(object sender, EventArgs e)
        {
            string title = "Andrew sent you a picture";
            string content = "Check this out, The Enchantments!";
            string image = "https://picsum.photos/364/202?image=883";
            int conversationId = 5;

            // Construct the toast content
            new ToastContentBuilder()

            // Arguments when user taps body of toast
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", conversationId)

            // Title and subtitle
            .AddText(title)
            .AddText(content)

            // Non-Desktop Bridge apps cannot use HTTP images, so
            // we download and reference the image locally
            .AddInlineImage(new Uri(await DownloadImageToDisk(image)))

            .AddAppLogoOverride(new Uri(await DownloadImageToDisk("https://unsplash.it/64?image=1005")), ToastGenericAppLogoCrop.Circle)

            .AddInputTextBox("tbReply", "Type a response")

            // Note that for non-UWP apps, there's no need to specify background activation,
            // since our activator decides whether to process in background or launch foreground window
            .AddButton(new ToastButton()
                .SetContent("Reply")
                .AddArgument("action", "reply")) // Actions added here supplement (and overwrite) top-level actions

            .AddButton(new ToastButton()
                .SetContent("Like")
                .AddArgument("action", "like"))

            .AddButton(new ToastButton()
                .SetContent("View")
                .AddArgument("action", "viewImage")
                .AddArgument("imageUrl", image))

            // And show the toast!
            .Show();
        }
    }
}
