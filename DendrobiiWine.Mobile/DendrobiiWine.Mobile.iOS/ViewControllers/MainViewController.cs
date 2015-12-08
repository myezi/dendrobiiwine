using DendrobiiWine.Shared.Models;
using System;

using UIKit;
using Foundation;
using System.Collections.Generic;

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
		//	tableView.Source = new TableSource(tableItems, this);
			Add (tableView);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

    public class MainTableViewSource : BaseTableViewSource<MerchantModel, MainViewController>
    {
        public MainTableViewSource(IList<MerchantModel> items, MainViewController viewController):base(items, viewController)
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // request a recycled cell to save memory
            UITableViewCell cell = tableView.DequeueReusableCell("cellIdentifier");
            // if there are no cells to reuse, create a new one
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cellIdentifier");

            cell.TextLabel.Text = tableItems[indexPath.Row].Name;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }
    }
}


