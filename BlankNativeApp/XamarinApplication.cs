using System;
using Xamarin.Forms;

namespace BlankNativeApp
{
    public class XamarinApplication : Application
    {
        public XamarinApplication()
        {
            MainPage = new NavigationPage(new TestPage());
        }
        public static void StaticOpenPage()
        {
            //
            iOS.AppDelegate.PresentPage();
        }

        public static void StaticClosePage()
        {
            //D
            iOS.AppDelegate.PopPage();
        }

        public static void Push(Page page)
        {
            //D
            iOS.AppDelegate.Push(page);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
