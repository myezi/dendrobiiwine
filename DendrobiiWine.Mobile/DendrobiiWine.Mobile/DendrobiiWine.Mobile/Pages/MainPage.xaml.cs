using DendrobiiWine.Mobile.Pages.Customer;
using DendrobiiWine.Mobile.Pages.Merchant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCustomer(object sender, EventArgs e)
        {
            App.Current.MainPage = BuildNavigationPage(new CustomerMainPage());
        }

        private async void OnMerchant(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MerchantMainPage());
        }

        private NavigationPage BuildNavigationPage(Page view)
        {
            var navigationPage = new NavigationPage(view);
            navigationPage.BarBackgroundColor = Color.FromRgb(13, 146, 198);
            navigationPage.BarTextColor = Color.White;

            return navigationPage;
        }
    }
}
