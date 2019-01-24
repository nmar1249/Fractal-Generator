using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalGenerator
{
    class KochCurve
    {

        private List<PointF> init;
        private List<float> genTheta;
        private float scaleFactor;
        public Bitmap img;
        private Graphics graph;

        public KochCurve(int width, int height)
        {
            
            float h = 0.65f * (Math.Min(width, height) - 20);
            float w = (float)(h / Math.Sqrt(3.0) * 2);
            float y3 = height - 10;
            float y1 = y3 - h;
            float x3 = height / 2;
            float x1 = x3 - w / 2;
            float x2 = x1 + w;
            float pi_over_3 = (float)(Math.PI / 3f);

            scaleFactor = 1 / 3f;
            img = new Bitmap(width, height);
            genTheta = new List<float>();
            init = new List<PointF>();
            graph = Graphics.FromImage(img);

            init.Add(new PointF(x1, y1));
            init.Add(new PointF(x2, y1));
            init.Add(new PointF(x3, y3));
            init.Add(new PointF(x1, y1));

            genTheta.Add(0);
            genTheta.Add(-pi_over_3);
            genTheta.Add(2 * pi_over_3);
            genTheta.Add(-pi_over_3);

        }

        public void generate(int d)
        {
            for(int i = 1; i < init.Count; i++)
            {
                PointF p1 = init[i - 1];
                PointF p2 = init[i];

                float dx = p2.X - p1.X;
                float dy = p2.Y - p1.Y;
                float len = (float)Math.Sqrt(dx * dx + dy * dy);
                float theta = (float)Math.Atan2(dy, dx);
                DrawEdge(d, ref p1, theta, len);
            }
        }

        public void DrawEdge(int depth, ref PointF p1, float theta, float dist)
        {
            if(depth == 0)
            {
                PointF p2 = new PointF((float)(p1.X + dist * Math.Cos(theta)),
                                       (float)(p1.Y + dist * Math.Sin(theta)));

                graph.DrawLine(Pens.Blue, p1, p2);
                p1 = p2;
                return;
            }

            dist *= scaleFactor;
            for (int i = 0; i < genTheta.Count; i++)
            {
                theta += genTheta[i];
                DrawEdge(depth - 1, ref p1, theta, dist);
            }
        }
    }
}
