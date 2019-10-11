using System;
using Xamarin.Forms;

namespace BlankNativeApp
{
    public interface IFormsNavigationService
    {
        void PushPage(Page page);
        void PopPage();
    }
}
