using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using UIKit;

namespace DendrobiiWine.Mobile.iOS.Views
{
    public class MerchantListViewCell : UITableViewCell
    {
        public MerchantListViewCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier)
        {
        }

        public override CGRect Frame
        {
            get
            {
                return base.Frame;
            }

            set
            {
                value.Y += 10;
                base.Frame = value;
            }
        }
    }
}
