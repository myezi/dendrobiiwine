using DendrobiiWine.Mobile.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Pages.Customer
{
    public partial class CustomerMainPage : ContentPage, INavigationBarOptions
    {
        public CustomerMainPage()
        {
            InitializeComponent();

            if(Device.OS == TargetPlatform.Android)
            {
                NavigationPage.SetHasBackButton(this, false);
            }
        }

        #region INavigationBarOptions

        public bool BackButtonVisible
        {
            get
            {
                return true;
            }
        }

        public IList<NavigationBarItem> LeftItems
        {
            get
            {
                return null;
            }
        }

        public IList<NavigationBarItem> RightItems
        {
            get
            {
                return null;
            }
        }

        #endregion
    }
}
