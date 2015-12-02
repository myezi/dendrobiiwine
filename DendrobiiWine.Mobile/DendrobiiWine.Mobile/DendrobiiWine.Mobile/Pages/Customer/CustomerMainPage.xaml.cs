using DendrobiiWine.Mobile.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Pages.Customer
{
    public partial class CustomerMainPage : ContentPage, INavigationBar
    {
        public CustomerMainPage()
        {
            InitializeComponent();
        }

        public IList<NavigationBarItem> LeftItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<NavigationBarItem> RightItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
