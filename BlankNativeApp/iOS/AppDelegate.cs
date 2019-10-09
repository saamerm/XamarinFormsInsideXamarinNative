using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace BlankNativeApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Forms.Init();
            return true;
        }
        public static void PopPage()
        {
            var appDelegate = UIApplication.SharedApplication.Delegate as FormsApplicationDelegate;
            var window = appDelegate.Window;
            if (window.RootViewController != null && window.RootViewController.NavigationController != null)
            {
                window.RootViewController.NavigationController.PopViewController(true);
            }
            else if (window.RootViewController.ModalViewController != null)
            {
                window.RootViewController.DismissModalViewController(true);
            }
        }
        public static void Push(Page page)
        {
            var appDelegate = UIApplication.SharedApplication.Delegate as FormsApplicationDelegate;
            var window = appDelegate.Window;
            var user = page.CreateViewController();
            user.View.BackgroundColor = UIColor.Blue;

            if (window.RootViewController.PresentedViewController != null && window.RootViewController.PresentedViewController.NavigationController != null)
                window.RootViewController.PresentedViewController.NavigationController.PushViewController(user, true);
            else if(window.RootViewController.NavigationController != null)
                window.RootViewController.NavigationController.PushViewController(user, true);
            else if (window.RootViewController != null)
                window.RootViewController.PresentViewController(user, true, null);

        }

        public static void PresentPage()
        {
            var  appDelegate = UIApplication.SharedApplication.Delegate as FormsApplicationDelegate;
            var window = appDelegate.Window;
            if (window.RootViewController != null)
            {
                var user = new TestPage().CreateViewController();
                user.View.BackgroundColor = UIColor.Blue;

                if (window.RootViewController.NavigationController == null)
                    window.RootViewController.PresentViewController(user, true, null);
                else
                    window.RootViewController.NavigationController.PushViewController(user, true);
            }
        }
    }
}

