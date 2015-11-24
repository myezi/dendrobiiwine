using DendrobiiWine.Mobile.Views.Customer;
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
            await Navigation.PushModalAsync(new NavigationPage(new MerchantListPage()));
        }
    }
}
