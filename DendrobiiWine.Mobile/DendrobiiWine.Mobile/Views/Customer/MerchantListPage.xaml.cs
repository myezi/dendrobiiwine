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
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                 new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
                new MerchantModel { Id=Guid.NewGuid().ToString(), DisplayName = "mono"},
            };
        }

        private async void OnCityActivated(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CityListPage()));
        }

        private async void OnGRcodeActivated(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRCodePage());
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var merchant = e.SelectedItem as MerchantModel;

            var merchantDetailPage = new MerchantDetailPage();
            merchantDetailPage.BindingContext = merchant;

            await Navigation.PushAsync(merchantDetailPage);
        }
    }
}
