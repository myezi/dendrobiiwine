using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DendrobiiWine.Droid
{
    [Activity(Label = "DendrobiiWine.Droid", MainLauncher = true, Theme = "@android:style/Theme.Holo.Light.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            // Login Button
            FindViewById<Button>(Resource.Id.btnLogin).Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(MerchantList)));
            };
        }
    }
}

