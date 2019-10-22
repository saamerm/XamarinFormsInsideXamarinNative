using System;
using Xamarin.Forms;

namespace BlankNativeApp
{
    public class XamarinApplication
    {
        public static Page ReturnPage()
        {
            return new NavigationPage(new TestPage());
        }

        public static void PopPage()
        {
            IFormsNavigationService service = DependencyService.Get<IFormsNavigationService>();
            Device.BeginInvokeOnMainThread(() => service.PopPage());
        }

        public static void PushPage(Page page)
        {
            IFormsNavigationService service = DependencyService.Get<IFormsNavigationService>();
            Device.BeginInvokeOnMainThread(() => service.PushPage(page));
        }
    }
}
