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

        protected override void OnAppearing()
        {
            _selectedMerchant = (MerchantModel)BindingContext;

            Title = _selectedMerchant.DisplayName;
        }
    }
}
