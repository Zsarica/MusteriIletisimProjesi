namespace MusteriIletisim.WinUI
{
    partial class frmIlgiAlani
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstIlgiAlanlari = new System.Windows.Forms.ListBox();
            this.lstEkliIlgiAlanlari = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnUstKategori = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Red;
            this.lblBaslik.Location = new System.Drawing.Point(133, 28);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(208, 14);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "İLGİ ALANLARINIZ NELERDİR ?";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(288, 390);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Müşteri Oluştur";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstIlgiAlanlari
            // 
            this.lstIlgiAlanlari.FormattingEnabled = true;
            this.lstIlgiAlanlari.Location = new System.Drawing.Point(72, 116);
            this.lstIlgiAlanlari.Name = "lstIlgiAlanlari";
            this.lstIlgiAlanlari.Size = new System.Drawing.Size(120, 251);
            this.lstIlgiAlanlari.TabIndex = 2;
            this.lstIlgiAlanlari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstIlgiAlanlari_MouseDoubleClick);
            // 
            // lstEkliIlgiAlanlari
            // 
            this.lstEkliIlgiAlanlari.Location = new System.Drawing.Point(288, 116);
            this.lstEkliIlgiAlanlari.Name = "lstEkliIlgiAlanlari";
            this.lstEkliIlgiAlanlari.Size = new System.Drawing.Size(120, 251);
            this.lstEkliIlgiAlanlari.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(213, 197);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(52, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(213, 238);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(52, 23);
            this.btnCikar.TabIndex = 1;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnUstKategori
            // 
            this.btnUstKategori.Location = new System.Drawing.Point(117, 87);
            this.btnUstKategori.Name = "btnUstKategori";
            this.btnUstKategori.Size = new System.Drawing.Size(75, 23);
            this.btnUstKategori.TabIndex = 3;
            this.btnUstKategori.Text = "Üst Kategori";
            this.btnUstKategori.UseVisualStyleBackColor = true;
            this.btnUstKategori.Click += new System.EventHandler(this.btnUstKategori_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(288, 431);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(120, 34);
            this.btnMusteriGuncelle.TabIndex = 4;
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // frmIlgiAlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 495);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnUstKategori);
            this.Controls.Add(this.lstEkliIlgiAlanlari);
            this.Controls.Add(this.lstIlgiAlanlari);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmIlgiAlani";
            this.Text = "İlgi Alanı Form";
            this.Load += new System.EventHandler(this.frmIlgiAlani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstIlgiAlanlari;
        private System.Windows.Forms.ListBox lstEkliIlgiAlanlari;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnUstKategori;
        private System.Windows.Forms.Button btnMusteriGuncelle;
    }
}