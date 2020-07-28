using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnAbout_Clicked(object sender, EventArgs e)
        {
            if(App.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.Detail = new NavigationPage(new AboutPage());
                masterDetailPage.IsPresented = false;
            }
        }

        private void btnLogout_Clicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.Detail = new NavigationPage(new LoginPage());
                masterDetailPage.IsPresented = false;
            }
        }

        private void btnNewOrder_Clicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.Detail = new NavigationPage(new OrderPage());
                masterDetailPage.IsPresented = false;
            }
        }

        private void btnSearchClient_Clicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.Detail = new NavigationPage(new ClientSearchPage());
                masterDetailPage.IsPresented = false;
            }
        }

        private void btnNextClient_Clicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.Detail = new NavigationPage(new NextClientPage());
                masterDetailPage.IsPresented = false;
            }
        }
    }
}