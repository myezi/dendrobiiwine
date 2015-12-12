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
				Title = "无锡",
			};

            var searchButton = new UIBarButtonItem
            {
                Image = UIImage.FromFile("search.png"),
            };
            searchButton.Clicked += delegate {
                this.NavigationController.PushViewController(new MerchantListViewController(), true);
            };
            this.NavigationItem.RightBarButtonItems = new UIBarButtonItem[] {
				searchButton,
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
			return 90f;
		}

		public override UIView GetViewForHeader (UITableView tableView, nint section)
		{
			if (section == 0) {
				var view = new UIView (new CGRect (0, 0, UIScreen.MainScreen.ApplicationFrame.Width, 80));
				view.BackgroundColor = UIColor.FromRGB(13, 146, 198);

				var containerView = new UIView (new CGRect (0, 0, UIScreen.MainScreen.ApplicationFrame.Width, 90));
				containerView.AddSubview (view);

				var foodImageView = new UIButton (UIButtonType.Custom);
				foodImageView.SetImage (UIImage.FromFile ("food.png"), UIControlState.Normal);
				foodImageView.SetTitle ("Food", UIControlState.Normal);
				foodImageView.SetTitleColor (UIColor.White, UIControlState.Normal);
				foodImageView.SetTitleColor (UIColor.Gray, UIControlState.Highlighted);
				foodImageView.ImageEdgeInsets = new UIEdgeInsets (-25, 5, 0, 0);
				foodImageView.TitleEdgeInsets = new UIEdgeInsets (30, -36, 0, 0);
				foodImageView.TitleLabel.TextAlignment = UITextAlignment.Center;
				foodImageView.Frame = new CGRect (10, 10, 50, 60);
				containerView.AddSubview (foodImageView);

				var firmImageView = new UIButton (UIButtonType.Custom);
				firmImageView.SetImage (UIImage.FromFile ("firm.png"), UIControlState.Normal);
				firmImageView.SetTitle ("Firm", UIControlState.Normal);
				firmImageView.SetTitleColor (UIColor.White, UIControlState.Normal);
				firmImageView.SetTitleColor (UIColor.Gray, UIControlState.Highlighted);
				firmImageView.ImageEdgeInsets = new UIEdgeInsets (-25, 5, 0, 0);
				firmImageView.TitleEdgeInsets = new UIEdgeInsets (30, -36, 0, 0);
				firmImageView.TitleLabel.TextAlignment = UITextAlignment.Center;
				firmImageView.Frame = new CGRect (90, 10, 50, 60);
				containerView.AddSubview (firmImageView);

				var hotelImageView = new UIButton (UIButtonType.Custom);
				hotelImageView.SetImage (UIImage.FromFile ("hotel.png"), UIControlState.Normal);
				hotelImageView.SetTitle ("Hotel", UIControlState.Normal);
				hotelImageView.SetTitleColor (UIColor.White, UIControlState.Normal);
				hotelImageView.SetTitleColor (UIColor.Gray, UIControlState.Highlighted);
				hotelImageView.ImageEdgeInsets = new UIEdgeInsets (-25, 5, 0, 0);
				hotelImageView.TitleEdgeInsets = new UIEdgeInsets (30, -36, 0, 0);
				hotelImageView.TitleLabel.TextAlignment = UITextAlignment.Center;
				hotelImageView.Frame = new CGRect (170, 10, 50, 60);
				containerView.AddSubview (hotelImageView);

				var voiceImageView = new UIButton (UIButtonType.Custom);
				voiceImageView.SetImage (UIImage.FromFile ("voice.png"), UIControlState.Normal);
				voiceImageView.SetTitle ("Voice", UIControlState.Normal);
				voiceImageView.SetTitleColor (UIColor.White, UIControlState.Normal);
				voiceImageView.SetTitleColor (UIColor.Gray, UIControlState.Highlighted);
				voiceImageView.ImageEdgeInsets = new UIEdgeInsets (-25, 5, 0, 0);
				voiceImageView.TitleEdgeInsets = new UIEdgeInsets (30, -36, 0, 0);
				voiceImageView.TitleLabel.TextAlignment = UITextAlignment.Center;
				voiceImageView.Frame = new CGRect (250, 10, 50, 60);
				containerView.AddSubview (voiceImageView);

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