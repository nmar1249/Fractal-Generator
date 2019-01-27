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
            this.fractalDisplay_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.save_Dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).BeginInit();
            this.fractalDisplay_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalBox
            // 
            this.fractalBox.Location = new System.Drawing.Point(12, 29);
            this.fractalBox.Name = "fractalBox";
            this.fractalBox.Size = new System.Drawing.Size(359, 320);
            this.fractalBox.TabIndex = 0;
            this.fractalBox.TabStop = false;
            this.fractalBox.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalBox_Paint);
            // 
            // fractalDisplay_menu
            // 
            this.fractalDisplay_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fractalDisplay_menu.Location = new System.Drawing.Point(0, 0);
            this.fractalDisplay_menu.Name = "fractalDisplay_menu";
            this.fractalDisplay_menu.Size = new System.Drawing.Size(384, 24);
            this.fractalDisplay_menu.TabIndex = 1;
            this.fractalDisplay_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImage_menu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImage_menu
            // 
            this.saveImage_menu.Name = "saveImage_menu";
            this.saveImage_menu.Size = new System.Drawing.Size(152, 22);
            this.saveImage_menu.Text = "Save Image";
            this.saveImage_menu.Click += new System.EventHandler(this.saveImage_menu_Click);
            // 
            // FractalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.fractalBox);
            this.Controls.Add(this.fractalDisplay_menu);
            this.MainMenuStrip = this.fractalDisplay_menu;
            this.Name = "FractalDisplay";
            this.Text = "FractalDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).EndInit();
            this.fractalDisplay_menu.ResumeLayout(false);
            this.fractalDisplay_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalBox;
        private System.Windows.Forms.MenuStrip fractalDisplay_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImage_menu;
        private System.Windows.Forms.SaveFileDialog save_Dialog;
    }
}