using System;

using Xamarin.Forms;

namespace DemoNav
{
    public class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            Master = new NavPage();
            Detail = new NavigationPage(new HomePage())
            {
                BarBackgroundColor = Color.FromHex("#efefef"),
                BarTextColor = Color.Black,
            };
        }
    }
}


