
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
    public class TestActivity : FormsAppCompatActivity
    {
        int count = 1;
        public static TestActivity Instance;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Instance = this;

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            Button button2 = FindViewById<Button>(Resource.Id.myButton2);
            button2.Click += Button2_Click;
            button.Click += delegate {
                StartActivity(typeof(SecondTestActivity));
            };
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}