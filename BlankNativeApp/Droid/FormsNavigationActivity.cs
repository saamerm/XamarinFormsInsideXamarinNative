
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace BlankNativeApp.Droid
{
    [Activity(Label = "BlankNativeApp", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class FormsNavigationActivity : FormsAppCompatActivity
    {
        public static FormsNavigationActivity Instance;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FragmentContainter);
            Android.Support.V4.App.Fragment fragment;
            fragment = new TestPage().CreateSupportFragment(this);

            SupportFragmentManager.BeginTransaction()
            .Replace(Resource.Id.fragmentContainer, fragment, "FormsBasePage").AddToBackStack(null)
            .Commit();
            Instance = this;
        }
    }
}
