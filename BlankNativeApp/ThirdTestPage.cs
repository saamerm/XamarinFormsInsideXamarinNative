using System;
using Xamarin.Forms;
namespace BlankNativeApp
{
    public class ThirdTestPage : ContentPage
    {
        public ThirdTestPage()
        {
            var label = new Label()
            {
                Text = "This is the third page"
            };
            var layout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            layout.Children.Add(label);
            Content = layout;
        }
    }
}
