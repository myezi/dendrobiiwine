using System;

using UIKit;

namespace DendrobiiWine.Mobile.iOS
{
	public partial class MainViewController : BaseTableViewController
	{
		public MainViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Navigation bar
			this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem{ 
				Title = "wuxi",
			};

			this.NavigationItem.RightBarButtonItems = new UIBarButtonItem[] {
				new UIBarButtonItem {
					Image = UIImage.FromFile ("user.png")	
				},
				new UIBarButtonItem {
					Image = UIImage.FromFile ("search.png")
				},
				new UIBarButtonItem {
					Image = UIImage.FromFile ("barcode.png")
				}
			};

			// Table view
			string[] tableItems = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
			tableView.Source = new TableSource(tableItems, this);
			Add (tableView);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class MainTableViewSource
}


