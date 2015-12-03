using DendrobiiWine.Mobile.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(ExtendedNavigationRenderer))]
namespace DendrobiiWine.Mobile.iOS.Renderers
{
    public class ExtendedNavigationRenderer : NavigationRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            
        }
    }
}
