using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamBase.Views
{
    class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            Master = new NavigationPage(new MenuPage())
            { Title = "Menu Principal" };

            Detail = new NavigationPage(new NextClientPage());
        }

    } 
}
