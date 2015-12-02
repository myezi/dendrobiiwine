using System.Threading.Tasks;
using Android.App;
using Android.Views;
using Android.Widget;
using DendrobiiWine.Mobile.App_Code;
using DendrobiiWine.Mobile.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(AppNavigationRenderer))]
namespace DendrobiiWine.Mobile.Droid.Renderers
{
    public class AppNavigationRenderer : NavigationRenderer
    {
        //protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        //{
        //    base.OnElementChanged(e);

        //    if (e.OldElement != null || Element == null)
        //    {
        //        return;
        //    }

        //    BuildNavigationBar();
        //}

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var result = base.OnPushAsync(view, animated);

            //BuildNavigationBar(view);

            return result;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
        }
        

        private void BuildNavigationBar(Page page)
        {
            if (!(page is INavigationBarOptions))
            {
                return;
            }

            var options = page as INavigationBarOptions;
            var activity = Context as Activity;
            var actionBar = activity.ActionBar;
            Android.Widget.RelativeLayout customView;

            #region Build Custome View

            customView = new Android.Widget.RelativeLayout(Context)
            {
                LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
            };

            Android.Views.View centerView;
            centerView = new TextView((Activity)Context)
            {
                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent),

                Text = DateTime.Now.ToString()
            };
            page.Title = null;
            customView.AddView(centerView);

            #endregion

            actionBar.SetIcon(Android.Resource.Color.Transparent);
            actionBar.SetDisplayShowHomeEnabled(false);
            actionBar.SetDisplayShowTitleEnabled(false);
            actionBar.CustomView = customView;
            actionBar.SetDisplayShowCustomEnabled(true);
        }
    }
}