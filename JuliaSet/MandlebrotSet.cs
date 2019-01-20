using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace FractalGenerator
{
    class MandlebrotSet
    {
        private int w;
        private int h;
        private static double max = 80;
        private static double MaxValueExtent = 1.25;
        private static double MaxNorm = MaxValueExtent * MaxValueExtent;

        public Bitmap img;

        public MandlebrotSet(int width, int height)
        {
            w = width;
            h = height;
            img = new Bitmap(w, h);
        }

        public void generate()
        {
            double s = 2 * MaxValueExtent / Math.Min(w, h);
            for (int y = 0; y < h; y++)
            {
                double zy = (h / 2 - y) * s;
                for (int x = 0; x < w; x++)
                {
                    double zx = (x - w / 2) * s;
                    double c = CalcColor(new ComplexNum(zx, zy));

                    double hue = c;
                    double saturation = 240;
                    double value = (c < max) ? value = 120 : value = 0;

                    HSLColor color = new HSLColor(hue, saturation, value);
                    img.SetPixel(x, y, color);
                }
            }
        }

        //these functions handle coloring.
        static double CalcColor(ComplexNum c)
        {
            ComplexNum z = new ComplexNum();
            double n = 0;
            int max_n = 1000;

            while (z.Norm() <= 2 && n < max_n)
            {
                z = z * z + c;
                n += 1;
            }

            if (n == max_n)
            {
                return max_n;
            }

            //this smooths out the color differences
            return n + 1 - Math.Log(Math.Log(z.Norm(), 2));

        }

        
        static Color GetColor(double v)
        {
            double m = 256;
            double contrast = 0.2;
            return Color.FromArgb((int)(m * Math.Pow(v, contrast)), 0, 0);
        }

        private double interp(int c1, int c2, int t)
        {
            return c1 * (1 - t) + c2 * t;
        }
    }

  
    
    //struct for complex numbers used to generate colors
    struct ComplexNum
    {
        public double Re;   //real axis
        public double Im;   //imaginary axis

        public ComplexNum(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexNum operator +(ComplexNum x, ComplexNum y)
        {
            return new ComplexNum(x.Re + y.Re, x.Im + y.Im);
        }

        public static ComplexNum operator *(ComplexNum x, ComplexNum y)
        {
            return new ComplexNum(x.Re * y.Re - x.Im * y.Im,
                x.Re * y.Im + x.Im * y.Re);
        }

        
        public double Norm()
        {
            return Re * Re + Im * Im;
        }
    }
}
