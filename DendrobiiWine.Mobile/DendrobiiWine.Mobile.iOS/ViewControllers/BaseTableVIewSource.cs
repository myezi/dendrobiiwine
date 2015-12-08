using System;
using CoreGraphics;
using UIKit;
using System.Collections.Generic;

namespace DendrobiiWine.Mobile.iOS
{
	public abstract class BaseTableViewSource<TSource, TViewController> : UITableViewSource
	{
		protected IList<TSource> tableItems;

		public BaseTableViewSource(IList<TSource> items, TViewController viewController)
		{
            tableItems = items;
		}
	}
}


