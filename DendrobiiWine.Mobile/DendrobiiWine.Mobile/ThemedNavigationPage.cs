using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DendrobiiWine.Mobile
{
    public class ThemedNavigationPage : NavigationPage
    {
        public ThemedNavigationPage(Page root) : base(root)
        {
            BarBackgroundColor = Color.Red;
        }
    }
}
