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

[assembly: Dependency(typeof(BarcodeService))]
namespace DendrobiiWine.Mobile.Droid
{
    public class BarcodeService : IBarCodeService
    {
        public Stream Generate(string contents, int width, int height)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = width,
                    Height = height
                },
                Renderer = new BitmapRenderer()
            };

            var bitmap = barcodeWriter.Write(contents);
            var stream = new MemoryStream();
            bitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
            stream.Position = 0;

            return stream;
        }

        public async Task<string> Scan()
        {
            var activity = Forms.Context as Activity;

            MobileBarcodeScanner.Initialize(activity.Application);

            var scanner = new MobileBarcodeScanner();
            scanner.TopText = "Hold the camera up to the barcode\nAbout 6 inches away";
            scanner.BottomText = "Wait for the barcode to automatically scan!";

            var result = await scanner.Scan();

            return result == null ? string.Empty : result.Text;
        }
    }
}