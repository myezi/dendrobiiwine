using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DendrobiiWine.Mobile.Services
{
    public interface IBarCodeService
    {
        Stream Generate(string contents, int width, int height);
    }
}
