using System;
namespace Pixelator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixellator Px = new Pixellator(args);
            Px.LoadImage();
            Px.Pixellate();
            //Px.SaveBitmap();
            var outPath = Px.ReturnBitmapPath();
            Console.WriteLine(outPath);

            //inputImage = new Bitmap(@"image.jpg");
            Console.WriteLine("xit");
            Console.ReadLine();
        }
    }
}
