using System;
using CoreGraphics;
using UIKit;

namespace DendrobiiWine.Mobile.iOS
{
	public abstract class BaseTableViewController : UITableViewController
	{
        protected UIActivityIndicatorView activityIndicatorView;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            activityIndicatorView = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.Gray);
            activityIndicatorView.Frame = new CGRect(100, 100, 50, 50);
            activityIndicatorView.HidesWhenStopped = false;

            this.View.AddSubview(activityIndicatorView);
            activityIndicatorView.StartAnimating();
        }
    }
}


