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

        private async void OnChangeCityActivated(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CityListPage()));
        }
    }
}
