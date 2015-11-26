using DendrobiiWine.Mobile.Views.Customer;
using DendrobiiWine.Mobile.Views.Merchant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ThemedNavigationPage(new MerchantListPage()));
        }

        private async void OnLogin1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ThemedNavigationPage(new ScannerPage()));
        }
    }
}
