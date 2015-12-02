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
            await Navigation.PushAsync(new CustomerMainPage());
        }

        private async void OnMerchant(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MerchantMainPage());
        }
    }
}
