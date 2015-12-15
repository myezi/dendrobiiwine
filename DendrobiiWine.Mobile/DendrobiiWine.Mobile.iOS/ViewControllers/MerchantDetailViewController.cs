using CoreGraphics;
using System;

using UIKit;
using Foundation;
using DendrobiiWine.Mobile.iOS.Views;
using System.Runtime.CompilerServices;

namespace DendrobiiWine.Mobile.iOS
{
    public partial class MerchantDetailViewController : UITableViewController
    {
        public MerchantDetailViewController() : base(UITableViewStyle.Grouped)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.NavigationItem.Title = "详情";
            this.NavigationController.NavigationBar.TopItem.Title = "";
        }
        
        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                var imgView = new UIImageView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 120));
                imgView.Image = UIImage.FromFile("test.jpg");

                return imgView;
            }

            return base.GetViewForHeader(tableView, section);
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return 120f;
            }
            else
            {
                return .1f;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return 2;
            }
            else
            {
                return 10;
            }
        }

        public override bool ShouldHighlightRow(UITableView tableView, NSIndexPath rowIndexPath)
        {
            if (rowIndexPath.Section == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell;

            if (indexPath.Section == 0)
            {
                if (indexPath.Row == 0)
                {
                    var cellIdentifier = "Section1Row1";
                    cell = tableView.DequeueReusableCell(cellIdentifier);
                    if (cell == null)
                        cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

                    cell.TextLabel.Text = "帅酷天天东北烧烤";
                    cell.TextLabel.TextColor = UIColor.Gray;
                }
                else
                {
                    var cellIdentifier = "Section1Row2";
                    cell = tableView.DequeueReusableCell(cellIdentifier);
                    if (cell == null)
                        cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

                    cell.TextLabel.Text = "滨湖区蠡湖街道湖滨商业街8-19";
                    cell.TextLabel.TextColor = UIColor.Gray;
                    cell.TextLabel.Font = UIFont.SystemFontOfSize(12);
                }
            }
            else
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "CategorySection");
            }
            
            return cell;
        }
    }
}


