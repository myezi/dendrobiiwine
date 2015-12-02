using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DendrobiiWine.Mobile.App_Code
{
    public class NavigationBarItem
    {
        public EventHandler Clicked;

        public string Text { get; set; }

        public string Icon { get; set; }
    }
}
