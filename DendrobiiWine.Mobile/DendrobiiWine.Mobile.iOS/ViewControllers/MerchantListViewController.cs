using CoreGraphics;
using System;

using UIKit;
using Foundation;
using DendrobiiWine.Mobile.iOS.Views;

namespace DendrobiiWine.Mobile.iOS
{
    public partial class MerchantListViewController : UIViewController
    {
        private UIView locationView;
        private UITableView tableView;

        private const int LocationViewFrameHeight = 20;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Init location view
            locationView = new UIView(new CGRect(
                0,
                NavigationController.NavigationBar.Frame.Height + UIApplication.SharedApplication.StatusBarFrame.Height,
                UIScreen.MainScreen.Bounds.Width,
                LocationViewFrameHeight));
            locationView.BackgroundColor = UIColor.Red;
            Add(locationView);

            // Init table view
            tableView = new UITableView(new CGRect(
                0,
                locationView.Frame.Y + LocationViewFrameHeight,
                UIScreen.MainScreen.Bounds.Width,
                UIScreen.MainScreen.Bounds.Height - LocationViewFrameHeight - NavigationController.NavigationBar.Frame.Height - UIApplication.SharedApplication.StatusBarFrame.Height));
            tableView.Source = new MerchantListTableViewSource();
            Add(tableView);
        }
    }

    public class MerchantListTableViewSource : UITableViewSource
    {
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell= new MerchantListViewCell("asdf");
            cell.TextLabel.Text = DateTime.Now.ToString();
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 15;
        }
    }
}


