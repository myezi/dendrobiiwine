using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DendrobiiWine.Mobile.App_Code
{
    public interface INavigationBarOptions
    {
        string Title { get; set; }

        bool BackButtonVisible { get; }

        IList<NavigationBarItem> LeftItems { get; }

        IList<NavigationBarItem> RightItems { get; }
    }
}
