using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using XamBase.Views;

namespace XamBase
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            Xamarin.Forms.TabbedPage tabbedPage = new Xamarin.Forms.TabbedPage();
            tabbedPage.Children.Add(new LoginPage());
            tabbedPage.Children.Add(new SignUpPage());
            tabbedPage.On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            MainPage = new NavigationPage(tabbedPage);
            //MainPage = new MainMasterDetailPage();
            

            //MainPage = new NavigationPage( new ClientSearchPage() );
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
