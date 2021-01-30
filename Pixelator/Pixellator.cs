using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Pixelator
{

    class Pixellator : IPixellator
    {
        public Bitmap InputImage { get; private set; }
        public Bitmap OutPutImage { get; private set; }
        public List<List<Color>> ColorOutput { get; set; }
        public string FilePath { get; private set; } = @"../../../testfile.jpg";// Add code to validate FilePath
        public int ?XOutputResolution { get; private set; } = null;
        public int ?YOutputResolution { get; private set; } = null;
        public int XInputResolution { get; set; }
        public int YInputResolution { get; set; }
        public int ScaleFactor { get; set; } = 10; // Will compress 10 pixels into one.

        public bool PreserveScale { get; set; } = true;

        public Pixellator(string[] args)
        {
            // if out is not defined, keep original scale!!!!
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-f")
                    {
                        FilePath = args[i + 1];
                    }
                    if (args[i] == "-h" || args[i].ToLower() == "help")
                    {
                        Console.WriteLine(Help.HelpString);
                    }
                    if (args[i] == "-s")
                    {
                        var result = int.TryParse(args[i + 1], out int factor);
                        ScaleFactor = result ? factor : 1;
                    }
                    if (args[i] == "-r")
                    {
                        var xResult = int.TryParse(args[i + 1], out int xRes);
                        var yResult = int.TryParse(args[i + 2], out int yRes);
                        if (!xResult) throw new Exception("X resolution was incorrectly entered");
                        if (!yResult) throw new Exception("Y resolution was incorrectly entered");
                        XOutputResolution = xRes;
                        YOutputResolution = yRes;
                        if (YOutputResolution != null || YOutputResolution == 0) PreserveScale = false; // If Given Y resolution is 0 or null, scale according to input
                    }

                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please enter a filename after [-f] argument");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadImage()
        {
            // The image has to be reduced in witdh and height such that total height & width%scaleFactor == 0;
            InputImage = new Bitmap(FilePath);
            XInputResolution = InputImage.Width;
            YInputResolution = InputImage.Height;
            var test = InputImage.GetPixel(0, 0);
            Console.WriteLine($"Width: {InputImage.Width}\nHeight: {InputImage.Height}\nScaleFactor: {ScaleFactor}");
        }

        public void Pixellate()
        {
            var xDim = XInputResolution / ScaleFactor;
            var yDim = YInputResolution / ScaleFactor;
            ColorOutput = new List<List<Color>>();
            for (int i = 0; i < XInputResolution; i += ScaleFactor)
            {
                var line = new List<Color>();
                for (int j = 0; j < YInputResolution; j += ScaleFactor)
                {
                    //line.Add(AveragePixels());
                }
                ColorOutput.Add(line);
            }
        }

        public string ReturnBitmapPath()
        {
            return "Not yet implemented";
        }

        public bool SaveBitmap()
        {
            throw new NotImplementedException();
        }

        public Color AveragePixels(List<Color> pixels)
        {
            var avgRList = pixels.Select(i => i.R).ToArray();
            var avgGList = pixels.Select(i => i.G).ToArray();
            var avgBList = pixels.Select(i => i.B).ToArray();
            int rSum = 0;
            int gSum = 0;
            int bSum = 0;
            for (int i = 0; i < avgRList.Length; i++)
            {
                rSum += avgRList[i];
                gSum += avgGList[i];
                bSum += avgBList[i];
            }
            int avgR = rSum / avgRList.Length;
            int avgG = gSum / avgGList.Length;
            int avgB = bSum / avgBList.Length;
            var col = Color.FromArgb(avgR, avgG, avgB);
            return col;

        }

        public List<Color> GetPixels(int xStart, int xEnd, int yStart, int yEnd)
        {
            List<Color> pixels = new List<Color>();
            for (int i = xStart; i < xEnd; i++)
            {
                for (int j = yStart; j < yEnd; j++)
                {
                    pixels.Add(InputImage.GetPixel(i, j)); // Add check to see if i or j is larger than bounds of image file!!!!!!
                }
            }
            return pixels;
        }
    }
}
