using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace FractalGenerator
{

    //the original triforce
    //
    //generating a sierpinski triangle using the "chaos game"
    public class SierpinskiTriangle
    {
        private int max = 250000;
        private int w;
        private int h;
        private int r;

        private Bitmap img;

        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }

        public SierpinskiTriangle(int x, int y)
        {
            w = x;
            h = y;
            img = new Bitmap(x, y);

        }

        public void Generate()
        {
            var initPoints = new Point[]
            {
                new Point(w / 2, 0),
                new Point(0, h),
                new Point(w, h)
            };
            Random rng = new Random();
            Point v = new Point(rng.Next(w), rng.Next(h));
            for (int i = 0; i < max; i++)
            {
                img.SetPixel(v.X, v.Y, Color.Red);
                r = rng.Next(3);
                v.X = (v.X + initPoints[r].X) / 2;
                v.Y = (v.Y + initPoints[r].Y) / 2;
            }
        }
    }
}
