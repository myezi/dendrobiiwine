using System;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Common;
using Android.Graphics;
using System.IO;
using DendrobiiWine.Mobile.Services;
using DendrobiiWine.Mobile.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(BarcodeService))]
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

        public string Scan()
        {
            return string.Empty;
        }
    }
}