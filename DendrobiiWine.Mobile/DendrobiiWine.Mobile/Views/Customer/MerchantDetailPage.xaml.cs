using DendrobiiWine.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class MerchantDetailPage : ContentPage
    {
        private MerchantModel _selectedMerchant;

        public MerchantDetailPage()
        {
            InitializeComponent();
        }

        private async void OnMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}
