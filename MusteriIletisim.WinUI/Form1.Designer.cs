namespace MusteriIletisim.WinUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kisiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kisiEkleToolStripMenuItem,
            this.mesajAtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kisiEkleToolStripMenuItem
            // 
            this.kisiEkleToolStripMenuItem.Name = "kisiEkleToolStripMenuItem";
            this.kisiEkleToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.kisiEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.kisiEkleToolStripMenuItem.Click += new System.EventHandler(this.kisiEkleToolStripMenuItem_Click);
            // 
            // mesajAtToolStripMenuItem
            // 
            this.mesajAtToolStripMenuItem.Name = "mesajAtToolStripMenuItem";
            this.mesajAtToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mesajAtToolStripMenuItem.Text = "Mesaj At";
            this.mesajAtToolStripMenuItem.Click += new System.EventHandler(this.mesajAtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kisiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajAtToolStripMenuItem;
    }
}

