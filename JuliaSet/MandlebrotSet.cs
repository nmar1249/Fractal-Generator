using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalGenerator
{
    class MandlebrotSet
    {
        private int w;
        private int h;
        private static int max = 1000;
        private static double MaxValueExtent = 2.0;
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
            for(int y = 0; y < h; y++)
            {
                double zy = (h / 2 - y) * s;
                for(int x = 0; x < w; x++)
                {
                    double zx = (x - w / 2) * s;
                    double c = CalcColor(new ComplexNum(zx, zy));
                    img.SetPixel(x, y, GetColor(c));
                }
            }
        }

        //these functions handle coloring. use of complex numbers helps achieve
        //a gradient effect
        static double CalcColor(ComplexNum n)
        {
            int i = 0;
            ComplexNum c = new FractalGenerator.ComplexNum();
            while(c.Norm() < MaxNorm && i < max)
            {
                c = c * c + n;
                i++;
            }
            if(i < max)
            {
                return (double)i / max;
            }
            else
            {
                return 0;
            }

        }
        static Color GetColor(double v)
        {
            double m = 256;
            double contrast = 0.2;
            return Color.FromArgb((int)(m * Math.Pow(v, contrast)), 0, 0);
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
