using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imgProc1
{
    class olahCitra
    {
        public static bool keBrightness(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 255;
                    int g1 = c1.G + 255;
                    int b1 = c1.B + 255;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keMerah(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 255;
                    int g1 = c1.G + 0;
                    int b1 = c1.B + 0;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keKuning(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 255;
                    int g1 = c1.G + 255;
                    int b1 = c1.B + 0;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keOrange(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 255;
                    int g1 = c1.G + 165;
                    int b1 = c1.B + 0;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keCyan(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 0;
                    int g1 = c1.G + 255;
                    int b1 = c1.B + 255;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool kePurple(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 128;
                    int g1 = c1.G + 0;
                    int b1 = c1.B + 128;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keGrey(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 128;
                    int g1 = c1.G + 128;
                    int b1 = c1.B + 128;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool keBrown(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + 150;
                    int g1 = c1.G + 75;
                    int b1 = c1.B + 0;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }
    }
}
