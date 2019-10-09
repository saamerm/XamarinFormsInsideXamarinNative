using Xamarin.Forms;

namespace BlankNativeApp
{
    public class TestPage : ContentPage
    {
        private TestPageViewModel viewModel;
        public TestPage()
        {
            viewModel = new TestPageViewModel();
            var label = new Label()
            {
                Text = viewModel.Title
            };
            var button1 = new Button()
            {
                Text = "Native Open"
            };
            button1.Pressed += Button1_Pressed;
            var button2 = new Button()
            {
                Text = "Native Close"
            };
            var button3 = new Button()
            {
                Text = "Open"
            };
            button3.Pressed += Button3_Pressed;
            var button4 = new Button()
            {
                Text = "Close"
            };
            button4.Pressed += Button4_Pressed;
            var stack = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            stack.Children.Add(label);
            stack.Children.Add(button1);
            stack.Children.Add(button2);
            stack.Children.Add(button3);
            stack.Children.Add(button4);
            Content = stack;
        }

        private void Button2_Pressed(object sender, System.EventArgs e)
        {
            XamarinApplication.StaticClosePage();
        }

        private void Button1_Pressed(object sender, System.EventArgs e)
        {
            XamarinApplication.StaticOpenPage();
            // PopAsync(this), RemovePage(this), PopToRootAsync is not supported globally on iOS, please use a NavigationPage. For PopModalAsync(true), error was Index was out of range
            //await Application.Current.MainPage.Navigation.PopModalAsync(true);
            //Application.ClosePage();
        }
        private async void Button3_Pressed(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new SecondTestPage()); // Didnt Work because is not supported globally on iOS
            XamarinApplication.Push(new SecondTestPage());
        }

        private void Button4_Pressed(object sender, System.EventArgs e)
        {
            XamarinApplication.StaticClosePage();
            // PopAsync(this), RemovePage(this), PopToRootAsync is not supported globally on iOS, please use a NavigationPage. For PopModalAsync(true), error was Index was out of range
            //await Application.Current.MainPage.Navigation.PopModalAsync(true);
            //Application.ClosePage();
        }
    }
}