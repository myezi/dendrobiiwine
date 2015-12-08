using DendrobiiWine.Shared.Models;
using System;
using CoreGraphics;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace DendrobiiWine.Mobile.iOS
{
	public partial class MainViewController : UITableViewController
	{
		public MainViewController():base(UITableViewStyle.Grouped){}

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
			//string[] tableItems = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
//			tableView.Source = new MainTableViewSource(new List<MerchantModel>{
//				new MerchantModel{Name = "asdfasdfasdf"},
//				new MerchantModel{Name = "asdfasdfasdf"},
//				new MerchantModel{Name = "asdfasdfasdf"},
//			}, this);
			//var tableView = new UITableView(new CGRect (0, 20, View.Bounds.Width, View.Bounds.Height), UITableViewStyle.Grouped);
			//tableView.Frame = ;
			//tableView.Style = UITableViewStyle.Grouped;
			//tableView.AutoresizingMask = UIViewAutoresizing.All;
			//tableView.Source = new MainTableViewSource(tableItems);
			//Add (tableView);
			//this.TableView = tableView;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 3;
		}
		public override nint RowsInSection (UITableView tableView, nint section)
		{
			if (section == 0) {
				return 1;
			} else {
				return 4;
			}
		}

		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			if (section == 0) {
				return .1f;
			} else {
				return 10f;
			}
		}

		public override nfloat GetHeightForFooter (UITableView tableView, nint section)
		{
			return .1f;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			if (indexPath.Section == 0) {
				UITableViewCell cell = tableView.DequeueReusableCell("CategorySection");
				// if there are no cells to reuse, create a new one
				if (cell == null) {
					//cell = new UITableViewCell (UITableViewCellStyle., "CategorySection");
				}

			}
			// request a recycled cell to save memory
			UITableViewCell cell = tableView.DequeueReusableCell("cellIdentifier");
			// if there are no cells to reuse, create a new one
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, "cellIdentifier");

			cell.TextLabel.Text = indexPath.Row.ToString();

			return cell;
		}
	}



	public class MainTableViewSource : UITableViewSource
    {
		protected string[] tableItems;
		public MainTableViewSource(string[] items)
        {
			tableItems = items;
        }

		public override nint NumberOfSections (UITableView tableView)
		{
			return 3;
		}



        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // request a recycled cell to save memory
            UITableViewCell cell = tableView.DequeueReusableCell("cellIdentifier");
            // if there are no cells to reuse, create a new one
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cellIdentifier");

            cell.TextLabel.Text = tableItems[indexPath.Row];

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
			return tableItems.Length;
        }
    }
}


