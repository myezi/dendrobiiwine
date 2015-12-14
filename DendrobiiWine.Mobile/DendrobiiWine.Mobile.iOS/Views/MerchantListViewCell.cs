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
        private UILabel moneyView;
        private UILabel soldView;

        public MerchantListViewCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier)
        {
            // Image View
            imageView = new UIImageView();
            imageView.Layer.CornerRadius = 2;
            imageView.Layer.MasksToBounds = true;

            // Header View
            headerView = new UILabel()
            {
                Font = UIFont.SystemFontOfSize(14)
            };

            // Description View
            descriptionView = new UILabel()
            {
                TextColor = UIColor.FromRGB(165, 165, 165),
                Font = UIFont.SystemFontOfSize(10),
            };

            // Money View
            moneyView = new UILabel()
            {
                TextColor = UIColor.FromRGB(249, 98, 104),
                Font = UIFont.SystemFontOfSize(10)
            };

            // Sold View
            soldView = new UILabel()
            {
                TextColor = UIColor.FromRGB(165, 165, 165),
                Font = UIFont.SystemFontOfSize(10),
                TextAlignment = UITextAlignment.Right
            };

            ContentView.AddSubviews(new UIView[] { imageView, headerView, descriptionView, soldView, moneyView });
        }

        public void UpdateCell(UIImage img, string header, string description, string money, string sold)
        {
            imageView.Image = img;
            headerView.Text = header;
            descriptionView.Text = description;
            moneyView.Text = money;
            soldView.Text = sold;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            imageView.Frame = new CGRect(12, 12, 65, 52);
            headerView.Frame = new CGRect(87, 10, 250, 20);
            descriptionView.Frame = new CGRect(87, 32, 220, 20);
            moneyView.Frame = new CGRect(87, 50, 110, 20);
            soldView.Frame = new CGRect(210, 50, 100, 20);
        }
    }
}
