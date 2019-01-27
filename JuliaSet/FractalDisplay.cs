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
        private Bitmap currentImage;
        private int depth;

        public FractalDisplay(int w, int h, string t)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(w + 41, h + 81);
                fractalBox.Size = new Size(w, h);
                Text = t;
                type = t;
            }
            catch(Exception e)
            {
                this.Close();
            }
        }

        //this one Generates a fractal with depth (like koch curves)
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
            else if(type == "Sierpinski Triangle")
            {
                GenerateSierpinskiTriagle(e);
            }
        }

        private void GenerateJuliaSet(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            JuliaSet set = new JuliaSet(fractalBox.Width, fractalBox.Height);

            set.generate();

            currentImage = set.Img;
            g.DrawImage(currentImage, 0, 0);
        }

        private void GenerateMandlebrotSet(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MandlebrotSet set = new MandlebrotSet(fractalBox.Width, fractalBox.Height);

            set.Generate();

            currentImage = set.Img;
            g.DrawImage(currentImage, 0, 0);
        }

        private void GenerateKochTriangle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            KochCurve kc = new KochCurve(fractalBox.Width, fractalBox.Height);

            kc.Generate(depth);

            currentImage = kc.Img;
            g.DrawImage(currentImage, 0, -70);
        }
        
        private void GenerateSierpinskiTriagle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SierpinskiTriangle st = new SierpinskiTriangle(fractalBox.Width, fractalBox.Height);

            st.Generate();

            currentImage = st.Img;
            g.DrawImage(currentImage, 0, 0);
        }
        private void saveImage_menu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_Dialog = new SaveFileDialog();

            save_Dialog.InitialDirectory = "C:/";
            save_Dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*png";
            save_Dialog.Title = "Save Fractal Image";
            save_Dialog.CheckPathExists = true;
            save_Dialog.DefaultExt = "jpg";

            if(save_Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentImage.Save(save_Dialog.FileName);
                }
                catch(Exception ex)
                {
                    if (currentImage == null)
                        MessageBox.Show("Please make sure a fractal is generated before saving", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Please enter a valid file name", "Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
                
            
        }
    }
}
