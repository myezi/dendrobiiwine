using DendrobiiWine.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class MerchantListPage : ContentPage
    {
        public MerchantListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            listView.ItemsSource = new List<MerchantModel>
            {
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
                new MerchantModel { DisplayName = "mono"},
            };
        }

        private async void OnCityActivated(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CityListPage()));
        }

        private async void OnItemSelected(object sender, EventArgs e)
        {
        }
    }
}
