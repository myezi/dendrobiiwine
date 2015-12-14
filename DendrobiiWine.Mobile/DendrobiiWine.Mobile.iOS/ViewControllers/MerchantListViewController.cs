using CoreGraphics;
using System;

using UIKit;
using Foundation;
using DendrobiiWine.Mobile.iOS.Views;
using DendrobiiWine.Shared;

namespace DendrobiiWine.Mobile.iOS
{
    public partial class MerchantListViewController : UITableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Init navigation bar
            this.NavigationItem.Title = "商家";
            this.NavigationController.NavigationBar.TopItem.Title = "";

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
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cellIdentifier = "MerchantListViewCell";
            var cell = tableView.DequeueReusableCell(cellIdentifier) as MerchantListViewCell;
            if (cell == null)
                cell = new MerchantListViewCell(cellIdentifier);

            cell.UpdateCell(UIImage.FromFile("test.jpg"), "帅酷天天东北烧烤", "中式烧烤 湖滨商业街", "￥100起", "已售1045");

            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 76f;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 15;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            this.NavigationController.PushViewController(new MerchantDetailViewController(), true);
        }
    }
}


