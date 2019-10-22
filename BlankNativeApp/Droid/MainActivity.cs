using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Android.Content;

namespace BlankNativeApp.Droid
{
    [Activity(Label = "BlankNativeApp", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : FormsAppCompatActivity
    {
        int count = 1;
        public static MainActivity Instance;

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

            // button2 is just used 
            Button button2 = FindViewById<Button>(Resource.Id.myButton2);
            button2.Visibility = Android.Views.ViewStates.Gone;
            button.Click += delegate {
                button.Text = $"{count++} clicks!";
                // Two main ways of Starting Activities:
                StartActivity(typeof(TestActivity));

                //var intent = new Intent(this, typeof(TestActivity));
                //StartActivity(intent);

            };
        }
    }
}

