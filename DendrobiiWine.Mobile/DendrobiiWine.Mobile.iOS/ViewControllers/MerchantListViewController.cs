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

            // Init navigation bar
            this.NavigationItem.Title = "商家";

            var searchButton = new UIBarButtonItem
            {
                Image = UIImage.FromFile("search.png"),
            };
            searchButton.Clicked += delegate {
                this.NavigationController.PushViewController(new MerchantListViewController(), true);
            };

            this.NavigationItem.RightBarButtonItems = new UIBarButtonItem[] 
            {
                searchButton
            };

            // Init location view
            //locationView = new UIView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, LocationViewFrameHeight));
            //locationView.BackgroundColor = UIColor.Red;
            //Add(locationView);

            // Init table view
            tableView = new UITableView(new CGRect(
                0,
                0,
                UIScreen.MainScreen.Bounds.Width,
                UIScreen.MainScreen.Bounds.Height - NavigationController.NavigationBar.Frame.Height - UIApplication.SharedApplication.StatusBarFrame.Height));
            tableView.Source = new MerchantListTableViewSource(this);
            Add(tableView);
        }
    }

    public class MerchantListTableViewSource : UITableViewSource
    {
        private UIViewController owner;

        public MerchantListTableViewSource(UIViewController viewController)
        {
            owner = viewController;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cellIdentifier = "MerchantListViewCell";
            var cell = tableView.DequeueReusableCell(cellIdentifier) as MerchantListViewCell;
            if (cell == null)
                cell = new MerchantListViewCell(cellIdentifier);

            cell.UpdateCell(UIImage.FromFile("test.jpg"), "帅酷天天东北烧烤", "中式烧烤 湖滨商业街", "1000", "已兑换105");

            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 76.0f;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 15;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            owner.NavigationController.PushViewController(new MerchantDetailViewController(), true);
        }
    }
}


