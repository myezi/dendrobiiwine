using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class QRCodePage : ContentPage
    {
        public QRCodePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            DependencyService.Get<IQRCode>().Generate("Hello from Xamarin Forms");
        }
    }
}
