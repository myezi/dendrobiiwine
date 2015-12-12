using System;
using System.Collections.Generic;
using System.Text;

namespace DendrobiiWine.Shared
{
    public class AppColor
    {
        public AppColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static AppColor FromRGB(int r, int g, int b)
        {
            return new AppColor(r, g, b);
        }

        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }
}
