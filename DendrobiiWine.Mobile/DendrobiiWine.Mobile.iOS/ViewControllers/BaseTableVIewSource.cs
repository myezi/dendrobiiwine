using System;
using CoreGraphics;
using UIKit;

namespace DendrobiiWine.Mobile.iOS
{
	public partial class BaseTableViewSource<TSource> : UITableViewSource
	{
		protected IList<> tableView;

		public BaseTableViewSource ()
		{
			this.View.BackgroundColor = UIColor.White;

			tableView = new UITableView(new CGRect(0, 20, View.Bounds.Width, View.Bounds.Height - 20));
			tableView.AutoresizingMask = UIViewAutoresizing.All;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


