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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DendrobiiWine.Mobile.Views.Merchant;
using DendrobiiWine.Mobile.Droid;
using ZXing.Mobile;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(ScannerPage), typeof(ScannerPageRenderer))]
namespace DendrobiiWine.Mobile.Droid
{
    public class ScannerPageRenderer : PageRenderer
    {
        private Activity _activity;
        private MobileBarcodeScanner _scanner;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetupUserInterface();

                Element.Appearing += async delegate {
                    await StartScanning();
                };
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"			ERROR: ", ex.Message);
            }
        }

        private void SetupUserInterface() {
            _activity = this.Context as Activity;
            MobileBarcodeScanner.Initialize(_activity.Application);
        }

        private async Task<string> StartScanning()
        {
            
            _scanner = new MobileBarcodeScanner();

            _scanner.TopText = "Hold the camera up to the barcode\nAbout 6 inches away";
            _scanner.BottomText = "Wait for the barcode to automatically scan!";
            _scanner.CancelButtonText = "Cancel";
            var result = await _scanner.Scan();

            HandleScanResult(result);

            return string.Empty;

        }

        private void HandleScanResult(ZXing.Result result)
        {
            string msg = "";

            if (result != null && !string.IsNullOrEmpty(result.Text))
                msg = "Found Barcode: " + result.Text;
            else
                msg = "Scanning Canceled!";

            System.Diagnostics.Debug.WriteLine(@"			ERROR: ", msg);
        }
    }
}