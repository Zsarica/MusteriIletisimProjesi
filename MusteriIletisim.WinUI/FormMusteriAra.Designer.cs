namespace MusteriIletisim.WinUI
{
    partial class frmMusteriAra
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
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.dgvMusteriListesi = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnMusteriOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(38, 48);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(104, 13);
            this.lblTcKimlikNo.TabIndex = 0;
            this.lblTcKimlikNo.Text = "TC Kimlik Numarası :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(148, 48);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(185, 20);
            this.txtTc.TabIndex = 1;
            this.txtTc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(365, 48);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(117, 23);
            this.btnMusteriAra.TabIndex = 2;
            this.btnMusteriAra.Text = "Müşteri Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // dgvMusteriListesi
            // 
            this.dgvMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListesi.Location = new System.Drawing.Point(41, 116);
            this.dgvMusteriListesi.Name = "dgvMusteriListesi";
            this.dgvMusteriListesi.Size = new System.Drawing.Size(292, 137);
            this.dgvMusteriListesi.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(365, 116);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(365, 145);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnMusteriOlustur
            // 
            this.btnMusteriOlustur.Location = new System.Drawing.Point(365, 213);
            this.btnMusteriOlustur.Name = "btnMusteriOlustur";
            this.btnMusteriOlustur.Size = new System.Drawing.Size(117, 40);
            this.btnMusteriOlustur.TabIndex = 5;
            this.btnMusteriOlustur.Text = "Müşteri Oluştur";
            this.btnMusteriOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriOlustur.Click += new System.EventHandler(this.btnMusteriOlustur_Click);
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 335);
            this.Controls.Add(this.btnMusteriOlustur);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvMusteriListesi);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Name = "frmMusteriAra";
            this.Text = "Müşteri Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.DataGridView dgvMusteriListesi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnMusteriOlustur;
    }
}