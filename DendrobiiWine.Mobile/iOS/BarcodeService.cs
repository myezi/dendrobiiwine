using DendrobiiWine.Mobile.iOS;
using DendrobiiWine.Mobile.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ZXing.Common;
using ZXing.Mobile;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(BarcodeService))]
namespace DendrobiiWine.Mobile.iOS
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
            var stream = bitmap.AsPNG().AsStream();
            stream.Position = 0;

            return stream;
        }

        public Task<string> Scan()
        {
            throw new NotImplementedException();
        }
    }
}
