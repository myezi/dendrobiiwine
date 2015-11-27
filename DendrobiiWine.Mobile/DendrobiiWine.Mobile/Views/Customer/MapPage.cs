using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            var map = new Map
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children = {
                    map
                }
            };
        }
    }
}
