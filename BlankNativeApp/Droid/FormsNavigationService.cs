using System;
using Android.App;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(BlankNativeApp.Droid.FormsNavigationService))]
namespace BlankNativeApp.Droid
{
    public class FormsNavigationService : IFormsNavigationService
    {
        public FormsNavigationService()
        {
        }

        public void PopPage()
        {
            var activity = FormsNavigationActivity.Instance;
            var supportFragmentManager = activity.SupportFragmentManager;
            activity.Finish();
        }

        public void PushPage(Page page)
        {
            var activity = FormsNavigationActivity.Instance;
            var supportFragmentManager = activity.SupportFragmentManager;
            var pageName = page.ToString();
            var intent = new Intent(activity, typeof(FormsNavigationActivity));
            intent.PutExtra("PageName", pageName);
            activity.StartActivity(intent);
        }
    }
}
