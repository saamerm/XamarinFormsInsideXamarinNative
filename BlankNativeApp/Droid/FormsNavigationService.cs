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
            if (activity.SupportFragmentManager.BackStackEntryCount > 1)
                activity.SupportFragmentManager.PopBackStackImmediate();
            else
                activity.Finish();
        }

        public void PushPage(Page page)
        {
            var activity = FormsNavigationActivity.Instance;

            // One way of doing it using new activities
            //var pageName = page.ToString();
            //var intent = new Intent(activity, typeof(FormsNavigationActivity));
            //intent.PutExtra("PageName", pageName);
            //activity.StartActivity(intent);

            // Second way of trying to do it, with fragments
            Android.Support.V4.App.Fragment fragment;
            if (page is ContentPage contentPage)
                fragment = PageExtensions.CreateSupportFragment(contentPage, activity);
            else
                fragment = new ThirdTestPage().CreateSupportFragment(activity);
            activity.SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.fragmentContainer, fragment, page.ToString()).AddToBackStack(null)
                .Commit();

            // Third try
            //var fragment = new ThirdTestPage().CreateSupportFragment(activity);
            //activity.SupportFragmentManager().beginTransaction()
            //             .replace(R.id.Layout_container, nextFrag, "findThisFragment")
            //             .addToBackStack(null)
            //             .commit();


        }
    }
}
