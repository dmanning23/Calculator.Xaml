using System;
using Xamarin.Forms;

namespace Calculator
{
    public class App
    {
        public static Page GetMainPage()
        {
            TabbedPage page = new TabbedPage();
            page.Children.Add(new NavigationPage(new FirstPage())
            {
                Title="Nav"
            });
            page.Children.Add(new OldMainPage());
            page.Children.Add(new MainPage());

            return page;
        }
    }
}

