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

    public partial class Form1 : Form
    {

        string height = "";
        string width = "";
        string fractalType = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Width_TextBox_TextChanged(object sender, EventArgs e)
        {
            width = Width_TextBox.Text;
        }

        private void Height_TextBox_TextChanged(object sender, EventArgs e)
        {
            height = Height_TextBox.Text;
        }

        private void Fractal_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            fractalType = Fractal_List.SelectedItem.ToString();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                FractalDisplay fd = new FractalDisplay(int.Parse(width), int.Parse(height), fractalType);
                fd.Activate();
                fd.Show();
            }
            catch(Exception ex)
            {
                //put an error message here at some point
            }
        }
    }
}
