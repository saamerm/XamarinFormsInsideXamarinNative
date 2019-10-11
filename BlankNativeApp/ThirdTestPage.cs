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
            var button = new Button()
            {
                Text = "Pop"
            };
            button.Pressed += Button_Pressed;
            var layout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            layout.Children.Add(label);
            layout.Children.Add(button);
            Content = layout;
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            XamarinApplication.PopPage();
        }
    }
}
