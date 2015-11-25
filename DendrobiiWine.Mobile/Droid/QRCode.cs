using System;
using DendrobiiWine.Mobile;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Common;
using Android.Graphics;

[assembly: Xamarin.Forms.Dependency(typeof(QRCode))]
public class QRCode : IQRCode
{
    public ImageSource Generate(string contents)
    {
        var barcodeWriter = new BarcodeWriter
        {
            Format = ZXing.BarcodeFormat.QR_CODE,
            Options = new EncodingOptions
            {
                Width = 300,
                Height = 300
            }
        };
        var barcode = barcodeWriter.Write("ZXing.Net.Mobile");
        
        return null;
    }
}