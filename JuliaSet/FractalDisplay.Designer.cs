namespace FractalGenerator
{
    partial class FractalDisplay
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
            this.fractalBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalBox
            // 
            this.fractalBox.Location = new System.Drawing.Point(13, 13);
            this.fractalBox.Name = "fractalBox";
            this.fractalBox.Size = new System.Drawing.Size(259, 236);
            this.fractalBox.TabIndex = 0;
            this.fractalBox.TabStop = false;
            this.fractalBox.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalBox_Paint);
            // 
            // FractalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fractalBox);
            this.Name = "FractalDisplay";
            this.Text = "FractalDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalBox;
    }
}