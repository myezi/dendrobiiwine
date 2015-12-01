using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DendrobiiWine.Droid
{
    public class NavigationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.ActionBar.SetDisplayShowHomeEnabled(false);
            this.ActionBar.SetDisplayShowTitleEnabled(false);

            LayoutInflater mInflater = LayoutInflater.From(this);
            View mCustomView = mInflater.Inflate(Resource.Layout.AppActionBar, null);
            TextView mTitleTextView = (TextView)mCustomView.FindViewById(Resource.Id.title_text);
            mTitleTextView.Text = "My Own Title";
            this.ActionBar.CustomView = mCustomView;
            this.ActionBar.SetDisplayShowCustomEnabled(true);
        }

        private void InitActionBar()
        {

        }
    }
}