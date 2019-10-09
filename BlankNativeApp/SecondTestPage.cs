using System;
using Xamarin.Forms;

namespace BlankNativeApp
{
    public class SecondTestPage : ContentPage
    {
        public SecondTestPage()
        {
            var label = new Label()
            {
                Text = "2nd Xamarin Forms"
            };
            var button = new Button()
            {
                Text = "Xamarin Forms Page close"
            };
            button.Pressed += Button_Pressed;
            var stack = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            stack.Children.Add(label);
            stack.Children.Add(button);
            Content = stack;
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
