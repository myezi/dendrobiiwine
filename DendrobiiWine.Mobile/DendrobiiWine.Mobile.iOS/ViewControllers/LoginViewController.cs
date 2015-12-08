using System;

using UIKit;

namespace DendrobiiWine.Mobile.iOS
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			var navigationBar = this.NavigationController.NavigationBar;
			//navigationBar.SetBackgroundImage(
				navigationBar.BarTintColor = UIColor.FromRGB(13, 146, 198);

			navigationBar.TintColor = UIColor.White;
			navigationBar.ShadowImage = new UIImage ();
			//navigationBar.BarStyle = UIBarStyle.Black;

			this.View.BackgroundColor = UIColor.FromRGB(13, 146, 198);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


