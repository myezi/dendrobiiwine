using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DendrobiiWine.Mobile.Services
{
    public interface IThirdPartyAppService
    {
         bool Link(string uri);
    }
}
