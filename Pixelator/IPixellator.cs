using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pixelator
{
    interface IPixellator
    {
        void LoadImage();
        void Pixellate();
        string ReturnBitmapPath();
        bool SaveBitmap();
        Color AveragePixels(List<Color> pixels);
        List<Color> GetPixels(int xStart, int xEnd, int yStart, int yEnd);
    }
}
