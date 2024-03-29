﻿using Foundation;
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
            var rootVC = appDelegate.Window.RootViewController;
            var vc = page.CreateViewController();

            if (rootVC.PresentedViewController != null && rootVC.PresentedViewController.NavigationController != null)
                rootVC.PresentedViewController.NavigationController.PushViewController(vc, true);
            else if(rootVC.NavigationController != null)
                rootVC.NavigationController.PushViewController(vc, true);
            else if (rootVC != null)
                rootVC.PresentViewController(vc, true, null);
        }

        public static void PresentPage()
        {
            var  appDelegate = UIApplication.SharedApplication.Delegate as FormsApplicationDelegate;
            var window = appDelegate.Window;
            if (window.RootViewController != null)
            {
                var user = new TestPage().CreateViewController();
                user.View.BackgroundColor = UIColor.Blue;
                 window.RootViewController.PresentViewController(user, true, null);
            }
        }
    }
}

