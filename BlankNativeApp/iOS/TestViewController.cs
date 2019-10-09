using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;

namespace BlankNativeApp.iOS
{
    public class TestViewController: UIViewController
    {
        public TestViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            Title = "My Custom View Controller";

            var btn = UIButton.FromType(UIButtonType.System);
            btn.Frame = new CGRect(20, 200, 280, 44);
            btn.SetTitle("Click Me", UIControlState.Normal);

            //var user = new TestPage();// new UIViewController();
            var user = new UIViewController();
            user.View.BackgroundColor = UIColor.Magenta;
            var appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;

            var user2 = new TestPage().CreateViewController();
            user2.View.BackgroundColor = UIColor.Blue;

            btn.TouchUpInside += (sender, e) => {
                //this.ShowViewController(user, (Foundation.NSObject)sender);
                //appDelegate.OpenXamarinApp();
                this.PresentViewController(user2, true, null);
            };

            View.AddSubview(btn);
        }
    }
}
