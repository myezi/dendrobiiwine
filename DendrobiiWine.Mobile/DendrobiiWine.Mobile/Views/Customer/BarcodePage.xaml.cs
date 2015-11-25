using DendrobiiWine.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class BarcodePage : ContentPage
    {
        public BarcodePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var barcodeStream = DependencyService.Get<IBarCodeService>().Generate("Hello from Xamarin Forms", 300, 300);

            barcdeImage.Source = ImageSource.FromStream(() => { return barcodeStream; });
        }
    }
}
