using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class CityListPage : ContentPage
    {
        public CityListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var geocoder = new Geocoder();
        }

        private async void OnSelectCity(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
