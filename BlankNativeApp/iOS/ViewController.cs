using System;

using UIKit;
using Xamarin.Forms;

namespace BlankNativeApp.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            //var user = new TestViewController();
            //user.View.BackgroundColor = UIColor.Blue;
            var user2 = new TestPage().CreateViewController();
            user2.View.BackgroundColor = UIColor.Blue;

            // wrap your VC inside a Nav controller
            var nav = new UINavigationController(user2);
            var appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            
            Button.TouchUpInside += delegate
            {

                //this.PresentViewControllerAsync(user, true);
                //this.PresentViewControllerAsync(user2, true);
                //this.PresentViewControllerAsync(nav, true);

                // If you want to replace the RootViewController with a navigation controller,
                // you can use this. It's useful after a login
                appDelegate.Window.RootViewController = nav;
                //var title = string.Format("{0} clicks!", count++);
                //Button.SetTitle(title, UIControlState.Normal);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
