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
            //foreach (var view in this.View.Subviews)
            //{
            //    var a = view.GetType();
            //    if (a.Name.Equals("UINavigationBarBackground", StringComparison.OrdinalIgnoreCase))
            //    {
                    
            //    }
            //}
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Naviagtion bar
            this.AutomaticallyAdjustsScrollViewInsets = false;
            this.NavigationController.NavigationBar.Alpha = 0.01f;
            // 设置为半透明
        }

        [CompilerGenerated]
        [Export("scrollViewDidScroll:")]
        public void Scrolled(UIScrollView scrollView)
        {
            var color = UIColor.Blue;
            var offsetY = scrollView.ContentOffset.Y;
            if (offsetY > 0)
            {
                var alpha = 1 - ((64 - offsetY) / 64);
                this.NavigationController.NavigationBar.Alpha = alpha;
            }
            else
            {
                this.NavigationController.NavigationBar.Alpha = 0.01f;
                this.NavigationController.NavigationItem.Title = "帅酷天天东北烧烤";
            }
        }


        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                var imgView = new UIImageView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 100));
                imgView.Image = UIImage.FromFile("test.jpg");

                return imgView;
            }

            return base.GetViewForHeader(tableView, section);
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return 100.0f;
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


