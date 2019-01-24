using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalGenerator
{
    public partial class FractalDisplay : Form
    {
        string type = "";
        public Bitmap image;
        public int depth;

        public FractalDisplay(int w, int h, string t)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(w + 41, h + 64);
                fractalBox.Size = new Size(w, h);
                Text = t;
                type = t;
            }
            catch(Exception e)
            {
                this.Close();
            }
        }

        //this one generates a fractal with depth (like koch curves)
        public FractalDisplay(int w, int h, int d, string t)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(w + 41, h + 64);
                fractalBox.Size = new Size(w, h);
                depth = d;
                Text = t;
                type = t;
            }
            catch (Exception e)
            {
                this.Close();
            }
        }


        private void fractalBox_Paint(object sender, PaintEventArgs e)
        {
            if(type == "Julia Set")
            {
                GenerateJuliaSet(e);
            }
            else if(type == "Mandlebrot Set")
            {
                GenerateMandlebrotSet(e);
            }
            else if(type == "Koch Curve")
            {
                GenerateKochTriangle(e);
            }

        }

        private void GenerateJuliaSet(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            JuliaSet set = new JuliaSet(Width, Height);

            set.generate();

            g.DrawImage(set.img, 0, 0);
        }

        private void GenerateMandlebrotSet(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MandlebrotSet set = new MandlebrotSet(Width, Height);

            set.generate();

            g.DrawImage(set.img, 0, 0);
        }

        private void GenerateKochTriangle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            KochCurve kc = new KochCurve(Width, Height);
            
            kc.generate(depth);


            g.DrawImage(kc.img, 0, -70);
            kc.img.Save("test.png");
        }

       
    }
}
