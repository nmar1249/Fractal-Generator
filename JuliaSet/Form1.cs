using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuliaSet
{
    public partial class formMain : Form
    {
        
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen myPen = new Pen(Color.Red);
            Brush myBrush = new SolidBrush(Color.Black);


            JuliaSet set = new JuliaSet(800, 600);

            set.generate();

            g.DrawImage(set.img, 0, 0);

        }
    }
}
