namespace FractalGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Width_TextBox = new System.Windows.Forms.TextBox();
            this.Height_TextBox = new System.Windows.Forms.TextBox();
            this.Fractal_List = new System.Windows.Forms.ListBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.depth_label = new System.Windows.Forms.Label();
            this.depth_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fractal \r\nType";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Width_TextBox
            // 
            this.Width_TextBox.Location = new System.Drawing.Point(50, 12);
            this.Width_TextBox.Name = "Width_TextBox";
            this.Width_TextBox.Size = new System.Drawing.Size(114, 20);
            this.Width_TextBox.TabIndex = 3;
            this.Width_TextBox.TextChanged += new System.EventHandler(this.Width_TextBox_TextChanged);
            // 
            // Height_TextBox
            // 
            this.Height_TextBox.Location = new System.Drawing.Point(49, 38);
            this.Height_TextBox.Name = "Height_TextBox";
            this.Height_TextBox.Size = new System.Drawing.Size(115, 20);
            this.Height_TextBox.TabIndex = 4;
            this.Height_TextBox.TextChanged += new System.EventHandler(this.Height_TextBox_TextChanged);
            // 
            // Fractal_List
            // 
            this.Fractal_List.FormattingEnabled = true;
            this.Fractal_List.Items.AddRange(new object[] {
            "Julia Set",
            "Mandlebrot Set",
            "Koch Curve",
            "Sierpinski Triangle"});
            this.Fractal_List.Location = new System.Drawing.Point(49, 89);
            this.Fractal_List.Name = "Fractal_List";
            this.Fractal_List.Size = new System.Drawing.Size(115, 56);
            this.Fractal_List.TabIndex = 5;
            this.Fractal_List.SelectedIndexChanged += new System.EventHandler(this.Fractal_List_SelectedIndexChanged);
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(233, 53);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 64);
            this.button_Generate.TabIndex = 6;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(7, 63);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(36, 13);
            this.depth_label.TabIndex = 7;
            this.depth_label.Text = "Depth";
            this.depth_label.Visible = false;
            // 
            // depth_textBox
            // 
            this.depth_textBox.Location = new System.Drawing.Point(49, 63);
            this.depth_textBox.Name = "depth_textBox";
            this.depth_textBox.Size = new System.Drawing.Size(115, 20);
            this.depth_textBox.TabIndex = 8;
            this.depth_textBox.Visible = false;
            this.depth_textBox.TextChanged += new System.EventHandler(this.depth_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.Controls.Add(this.depth_textBox);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.Fractal_List);
            this.Controls.Add(this.Height_TextBox);
            this.Controls.Add(this.Width_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fractal Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width_TextBox;
        private System.Windows.Forms.TextBox Height_TextBox;
        private System.Windows.Forms.ListBox Fractal_List;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.TextBox depth_textBox;
    }
}