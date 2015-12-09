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
			var navigationBar = this.NavigationController.NavigationBar;
			navigationBar.BarTintColor = UIColor.FromRGB(13, 146, 198);
			navigationBar.TintColor = UIColor.White;
			navigationBar.SetBackgroundImage (UIImage.FromFile ("bg_blue.png"), UIBarMetrics.Default);
			navigationBar.ShadowImage = new UIImage ();
			navigationBar.BarStyle = UIBarStyle.BlackOpaque;

			this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem{ 
				Title = "wuxi",
			};

			this.NavigationItem.RightBarButtonItems = new UIBarButtonItem[] {
				new UIBarButtonItem {
					Image = UIImage.FromFile ("search.png")
				},
				new UIBarButtonItem {
					Image = UIImage.FromFile ("barcode.png")
				},
				new UIBarButtonItem {
					Image = UIImage.FromFile ("user.png")	
				}
			};
		}
			
		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return 4;
		}

		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			return 100f;
		}

		public override UIView GetViewForHeader (UITableView tableView, nint section)
		{
			if (section == 0) {
				var view = new UIView (new CGRect (0, 0, UIScreen.MainScreen.ApplicationFrame.Width, 90));
				view.BackgroundColor = UIColor.FromRGB(13, 146, 198);

				var containerView = new UIView (new CGRect (0, 0, UIScreen.MainScreen.ApplicationFrame.Width, 100));
				containerView.AddSubview (view);

				return containerView;
			}

			return base.GetViewForHeader (tableView, section);
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			if (indexPath.Section == 0 && indexPath.Row == 0) {
				return 20f;
			} else {
				return base.GetHeightForRow (tableView, indexPath);
			}
		}
			
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell;
			if (indexPath.Section == 0) {
				cell = tableView.DequeueReusableCell ("CategorySection");
				// if there are no cells to reuse, create a new one
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Default, "CategorySection");

					//cell.BackgroundColor = UIColor.FromRGB (13, 146, 198);
				}

			} else {
				cell = new UITableViewCell (UITableViewCellStyle.Default, "CategorySection");
			}

			return cell;
		}
	}
}