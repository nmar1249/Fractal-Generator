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
        string depth = "";
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

        private void depth_textBox_TextChanged(object sender, EventArgs e)
        {
            depth = depth_textBox.Text;
        }


        private void Fractal_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fractalType = Fractal_List.SelectedItem.ToString();
                if(fractalType == "Koch Curve")
                {
                    depth_label.Visible = true;
                    depth_textBox.Visible = true;
                }
                else
                {
                    depth_label.Visible = false;
                    depth_textBox.Visible = false;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                FractalDisplay fd;
                if (fractalType != "Koch Curve")
                    fd = new FractalDisplay(int.Parse(width), int.Parse(height), fractalType);
                else
                    fd = new FractalDisplay(int.Parse(width), int.Parse(height), int.Parse(depth), fractalType);

                fd.Activate();
                fd.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure that all inputs are valid integers.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        
    }
}
