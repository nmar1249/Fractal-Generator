﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuliaSet
{
    class JuliaSet
    {
        private int w;
        private int h;
        private static int zoom = 1;
        private static int max = 255;
        private static int moveX = 0;
        private static int moveY = 0;
        private static double cX = -0.7;
        private static double cY = 0.27015;

        double zx, zy, temp;
        int i;

        public Bitmap img;

       public JuliaSet(int width, int height)
       {
            w = width;
            h = height;
            img = new Bitmap(w, h);
       }

       
        public void generate()
        {
            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36,
                                                (c & 3) * 85)).ToArray();

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    zx = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    zy = 1.0 * (y - h / 2) / (0.5 * zoom * h) + moveY;
                    i = max;
                    while (zx * zx + zy * zy < 4 && i > 1)
                    {
                        temp = zx * zx - zy * zy + cX;
                        zy = 2.0 * zx * zy + cY;
                        zx = temp;
                        i -= 1;
                    }
                    img.SetPixel(x, y, colors[i]);
                }
            }
        }

        public void save(string fileName)
        {
            img.Save(fileName);
        }
    }
}