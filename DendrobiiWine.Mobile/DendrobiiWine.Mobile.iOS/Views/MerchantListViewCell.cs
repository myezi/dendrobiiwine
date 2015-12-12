using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using UIKit;

namespace DendrobiiWine.Mobile.iOS.Views
{
    public class MerchantListViewCell : UITableViewCell
    {
        private UIImageView imageView;
        private UILabel headerView;
        private UILabel descriptionView;
        private UILabel pointView;
        private UILabel convertedView;

        public MerchantListViewCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier)
        {
            // Image View
            imageView = new UIImageView();

            // Header View
            headerView = new UILabel()
            {
                Font = UIFont.SystemFontOfSize(14)
            };

            // Description View
            descriptionView = new UILabel()
            {
                TextColor = UIColor.Gray,
                Font = UIFont.SystemFontOfSize(12)
            };

            // Point View
            pointView = new UILabel();

            // Converted View
            convertedView = new UILabel();

            ContentView.AddSubviews(new UIView[] {imageView, headerView, descriptionView, pointView, convertedView});
        }

        public void UpdateCell(UIImage img, string header, string description, string point, string converted)
        {
            imageView.Image = img;
            headerView.Text = header;
            descriptionView.Text = description;
            pointView.Text = point;
            convertedView.Text = converted;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            imageView.Frame = new CGRect(8, 8, 78, 62);
            headerView.Frame = new CGRect(90, 8, 250, 20);
            descriptionView.Frame = new CGRect(90, 32, 250, 20);
        }
    }
}
