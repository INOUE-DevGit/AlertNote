using Plugin.LocalNotification;

namespace AlertNote
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSetNotificationClicked(object sender, EventArgs e)
        {
            var memoText = MemoEntry.Text;
            if (!string.IsNullOrWhiteSpace(memoText))
            {
                var notification = new NotificationRequest
                {
                    NotificationId = 100,
                    Title = "AlertNote",
                    Subtitle = "Notification",
                    Description = memoText,
                    BadgeNumber = 1,
                    Schedule = new NotificationRequestSchedule
                    {
                        NotifyTime = DateTime.Now.AddSeconds(5) // 5秒後に通知
                    }
                };

                LocalNotificationCenter.Current.Show(notification);
            }
        }
    }
}
