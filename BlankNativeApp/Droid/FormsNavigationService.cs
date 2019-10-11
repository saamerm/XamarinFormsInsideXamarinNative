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

            // One way of doing it using removal of activities
            activity.Finish();
            // Does not work occasionally from some testing. Although back button always workd

            // Second way of doing it using the Fragments:
            //var supportFragmentManager = activity.SupportFragmentManager;
            //supportFragmentManager.PopBackStack();
            //supportFragmentManager.PopBackStackImmediate();
        }

        public void PushPage(Page page)
        {
            var activity = FormsNavigationActivity.Instance;

            // One way of doing it using new activities
            var pageName = page.ToString();
            var intent = new Intent(activity, typeof(FormsNavigationActivity));
            intent.PutExtra("PageName", pageName);
            activity.StartActivity(intent);

            // Second way of trying to do it, with fragments
            //var fragment = new ThirdTestPage().CreateSupportFragment(activity);
            //var supportFragmentManager = activity.SupportFragmentManager;
            //supportFragmentManager.BeginTransaction()
            //    .Add(fragment, "FormsPage")//.AddToBackStack("FormsPage")
            //    .Commit();
        }
    }
}
