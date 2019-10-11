using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(BlankNativeApp.iOS.FormsNavigationService))]
namespace BlankNativeApp.iOS
{
    public class FormsNavigationService : IFormsNavigationService
    {
        public FormsNavigationService()
        {
        }

        public void PopPage()
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

        public void PushPage(Page page)
        {
            var appDelegate = UIApplication.SharedApplication.Delegate as FormsApplicationDelegate;
            var rootVC = appDelegate.Window.RootViewController;
            var vc = page.CreateViewController();

            if (rootVC.PresentedViewController != null && rootVC.PresentedViewController.NavigationController != null)
                rootVC.PresentedViewController.NavigationController.PushViewController(vc, true);
            else if (rootVC.NavigationController != null)
                rootVC.NavigationController.PushViewController(vc, true);
            else if (rootVC != null)
                rootVC.PresentViewController(vc, true, null);
        }
    }
}
