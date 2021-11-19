using Android.App;
using Firebase.Messaging;

namespace FirstApp.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class FirstAppMessagingService : FirebaseMessagingService
    {
        public override void OnMessageReceived(RemoteMessage p0)
        {
            base.OnMessageReceived(p0);
        }

        public override void OnNewToken(string p0)
        {
            base.OnNewToken(p0);
        }
    }
}