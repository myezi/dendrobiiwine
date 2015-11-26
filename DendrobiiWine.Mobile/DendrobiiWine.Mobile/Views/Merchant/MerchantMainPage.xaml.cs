using DendrobiiWine.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Merchant
{
    public partial class MerchantMainPage : ContentPage
    {
        public MerchantMainPage()
        {
            InitializeComponent();
        }

        private async void OnScanActivated(object sender, EventArgs e)
        {
            var code = await DependencyService.Get<IBarCodeService>().Scan();

            await DisplayAlert("Barcode", code, "OK");
        }
    }
}
