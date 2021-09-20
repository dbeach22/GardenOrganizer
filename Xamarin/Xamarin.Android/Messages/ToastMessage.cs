using Android.App;
using Android.Widget;
using XamarinUI.Messages.Interfaces;

namespace XamarinUI.Droid.Messages
{
    public class ToastMessage : IToastMessage
    {
        public void Show(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}