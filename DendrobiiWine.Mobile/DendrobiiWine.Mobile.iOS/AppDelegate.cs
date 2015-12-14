using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using DendrobiiWine.Shared;

namespace DendrobiiWine.Mobile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            var navigationController = new UINavigationController(new MainViewController());
            navigationController.NavigationBar.TintColor = UIColor.White;
            navigationController.NavigationBar.SetBackgroundImage(UIImage.FromFile("navbar_bg.png"), UIBarMetrics.Default);
            navigationController.NavigationBar.ShadowImage = new UIImage();
            navigationController.NavigationBar.BarStyle = UIBarStyle.BlackOpaque;
            
            window.RootViewController = navigationController;
            window.MakeKeyAndVisible();

            return true;
        }
    }
}