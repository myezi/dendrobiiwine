using DendrobiiWine.Mobile.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Pages.Customer
{
    public partial class CustomerMainPage : ContentPage
    {
        public CustomerMainPage()
        {
            InitializeComponent();
        }

        private async void OnCityClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CityListPage());
        }

        private async void OnBarCodeClick(object sender, EventArgs e) { }

        private async void OnSearchClick(object sender, EventArgs e) { }

        private async void OnProfileClick(object sender, EventArgs e) { }
    }
}
