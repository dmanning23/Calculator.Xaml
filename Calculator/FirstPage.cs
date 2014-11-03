using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            var panel = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing =15
            };

            var button = new Button()
            {
                Text = "Calc!"
            };
            button.Clicked += async (sender, e) =>
                {
                    await this.Navigation.PushAsync(new MainPage());
                };
            panel.Children.Add(button);

            var button2 = new Button()
            {
                Text = "Old Calc!"
            };
            button2.Clicked += async (sender, e) =>
            {
                await this.Navigation.PushAsync(new OldMainPage());
            };
            panel.Children.Add(button2);

            this.Content = panel;
        }
    }
}
