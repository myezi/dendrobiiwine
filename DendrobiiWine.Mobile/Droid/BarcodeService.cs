using System;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Common;
using Android.Graphics;
using System.IO;
using DendrobiiWine.Mobile.Services;

[assembly: Xamarin.Forms.Dependency(typeof(BarcodeService))]
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
            }
        };
        var barcode = barcodeWriter.Write("ZXing.Net.Mobile");

        var stream = new MemoryStream();
        barcode.Compress(Bitmap.CompressFormat.Png, 100, stream);
        stream.Position = 0;

        return stream;
    }
}