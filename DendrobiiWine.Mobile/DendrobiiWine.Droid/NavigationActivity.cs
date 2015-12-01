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
    public abstract class NavigationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            InitActionBar();
        }

        protected virtual void InitActionBar()
        {
            this.ActionBar.SetDisplayShowHomeEnabled(false);
            this.ActionBar.SetDisplayShowTitleEnabled(false);

            View actionBar = LayoutInflater.From(this).Inflate(Resource.Layout.AppActionBar, null);

            this.ActionBar.CustomView = actionBar;
            //this.ActionBar.CustomView = BuildActionBar();
            this.ActionBar.SetDisplayShowCustomEnabled(true);
        }

        protected virtual View BuildActionBar()
        {
            var model = InitActionBarModel();
            var root = new RelativeLayout(ApplicationContext)
            {
                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
            };

            View centerView;
            if (!string.IsNullOrEmpty(model.Title))
            {
                centerView = new TextView(ApplicationContext)
                {
                    LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent),

                    Text = model.Title
                };
            }
            else
            {
                centerView = model.CenterView;
            }
            root.AddView(centerView);

            return root;
        }

        protected abstract ActionBarModel InitActionBarModel();
    }

    public class ActionBarModel
    {
        public string Title { get; set; }
        public View CenterView { get; set; }
        public IList<View> LeftViews{get;set;}
        public IList<View> RightViews { get; set; }
        public bool IsShowBackButton { get; set; }
    }
}