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

        public FractalDisplay(int w, int h, string t)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(w, h);
                Text = t;
                type = t;
            }
            catch(Exception e)
            {
                this.Close();
            }
        }

        private void FractalDisplay_Paint(object sender, PaintEventArgs e)
        {
            if(type == "Julia Set")
            {
                GenerateJuliaSet(e);
            }
            else if(type == "Mandlebrot Set")
            {
                GenerateMandlebrotSet(e);
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
    }
}
