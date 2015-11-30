using System;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Common;
using Android.Graphics;
using System.IO;
using DendrobiiWine.Mobile.Services;
using DendrobiiWine.Mobile.Droid;
using System.Threading.Tasks;
using Android.App;
using Android.Content;

[assembly: Dependency(typeof(ThirdPartyAppService))]
namespace DendrobiiWine.Mobile.Droid
{
    public class ThirdPartyAppService : IThirdPartyAppService
    {
        public bool Link(string uri)
        {
            var activity = Forms.Context as Activity;

            var intent = Intent.GetIntent(uri);

            try
            {
                activity.StartActivity(intent);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}