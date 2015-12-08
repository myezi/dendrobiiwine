﻿using System;
using CoreGraphics;
using UIKit;

namespace DendrobiiWine.Mobile.iOS
{
	public abstract class BaseTableViewController : UITableViewController
	{
		protected UITableView tableView;

		public BaseTableViewController ()
		{
			this.View.BackgroundColor = UIColor.White;


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


