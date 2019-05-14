namespace MusteriIletisim.WinUI
{
    partial class FormMesajAt
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
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbMedHal = new System.Windows.Forms.ComboBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.lstIlgiAlanlari = new System.Windows.Forms.ListBox();
            this.lstIlgiAlanlari2 = new System.Windows.Forms.ListBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgvKisiGoster = new System.Windows.Forms.DataGridView();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblMedHal = new System.Windows.Forms.Label();
            this.lblil = new System.Windows.Forms.Label();
            this.lblilce = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnUstKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(83, 25);
            this.txtYas.MaxLength = 2;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 0;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(83, 66);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 1;
            // 
            // cmbMedHal
            // 
            this.cmbMedHal.FormattingEnabled = true;
            this.cmbMedHal.Location = new System.Drawing.Point(83, 106);
            this.cmbMedHal.Name = "cmbMedHal";
            this.cmbMedHal.Size = new System.Drawing.Size(121, 21);
            this.cmbMedHal.TabIndex = 2;
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(343, 66);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(121, 21);
            this.cmbilce.TabIndex = 3;
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(343, 25);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 4;
            // 
            // lstIlgiAlanlari
            // 
            this.lstIlgiAlanlari.FormattingEnabled = true;
            this.lstIlgiAlanlari.Location = new System.Drawing.Point(83, 172);
            this.lstIlgiAlanlari.Name = "lstIlgiAlanlari";
            this.lstIlgiAlanlari.Size = new System.Drawing.Size(121, 134);
            this.lstIlgiAlanlari.TabIndex = 5;
            this.lstIlgiAlanlari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstIlgiAlanlari_MouseDoubleClick);
            // 
            // lstIlgiAlanlari2
            // 
            this.lstIlgiAlanlari2.FormattingEnabled = true;
            this.lstIlgiAlanlari2.Location = new System.Drawing.Point(344, 172);
            this.lstIlgiAlanlari2.Name = "lstIlgiAlanlari2";
            this.lstIlgiAlanlari2.Size = new System.Drawing.Size(120, 134);
            this.lstIlgiAlanlari2.TabIndex = 6;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(239, 197);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(63, 23);
            this.btnIleri.TabIndex = 7;
            this.btnIleri.Text = ">>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(239, 252);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(63, 23);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "<<";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // dgvKisiGoster
            // 
            this.dgvKisiGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiGoster.Location = new System.Drawing.Point(83, 389);
            this.dgvKisiGoster.Name = "dgvKisiGoster";
            this.dgvKisiGoster.Size = new System.Drawing.Size(381, 164);
            this.dgvKisiGoster.TabIndex = 9;
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(569, 389);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.Size = new System.Drawing.Size(254, 122);
            this.rtxtMesaj.TabIndex = 10;
            this.rtxtMesaj.Text = "";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(400, 337);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(64, 23);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(748, 530);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 12;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(12, 28);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(31, 13);
            this.lblYas.TabIndex = 13;
            this.lblYas.Text = "Yaş :";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(12, 69);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(49, 13);
            this.lblCinsiyet.TabIndex = 13;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // lblMedHal
            // 
            this.lblMedHal.AutoSize = true;
            this.lblMedHal.Location = new System.Drawing.Point(12, 109);
            this.lblMedHal.Name = "lblMedHal";
            this.lblMedHal.Size = new System.Drawing.Size(67, 13);
            this.lblMedHal.TabIndex = 13;
            this.lblMedHal.Text = "Medeni Hal :";
            // 
            // lblil
            // 
            this.lblil.AutoSize = true;
            this.lblil.Location = new System.Drawing.Point(307, 28);
            this.lblil.Name = "lblil";
            this.lblil.Size = new System.Drawing.Size(18, 13);
            this.lblil.TabIndex = 13;
            this.lblil.Text = "İl :";
            // 
            // lblilce
            // 
            this.lblilce.AutoSize = true;
            this.lblilce.Location = new System.Drawing.Point(307, 69);
            this.lblilce.Name = "lblilce";
            this.lblilce.Size = new System.Drawing.Size(30, 13);
            this.lblilce.TabIndex = 13;
            this.lblilce.Text = "İlçe :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(522, 392);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(41, 13);
            this.lblMesaj.TabIndex = 13;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // btnUstKategori
            // 
            this.btnUstKategori.Location = new System.Drawing.Point(129, 143);
            this.btnUstKategori.Name = "btnUstKategori";
            this.btnUstKategori.Size = new System.Drawing.Size(75, 23);
            this.btnUstKategori.TabIndex = 14;
            this.btnUstKategori.Text = "Üst Kategori";
            this.btnUstKategori.UseVisualStyleBackColor = true;
            this.btnUstKategori.Click += new System.EventHandler(this.BtnUstKategori_Click);
            // 
            // FormMesajAt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 578);
            this.Controls.Add(this.btnUstKategori);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblilce);
            this.Controls.Add(this.lblil);
            this.Controls.Add(this.lblMedHal);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.rtxtMesaj);
            this.Controls.Add(this.dgvKisiGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.lstIlgiAlanlari2);
            this.Controls.Add(this.lstIlgiAlanlari);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbMedHal);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtYas);
            this.Name = "FormMesajAt";
            this.Text = "FormMesajAt";
            this.Load += new System.EventHandler(this.FormMesajAt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbMedHal;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ListBox lstIlgiAlanlari;
        private System.Windows.Forms.ListBox lstIlgiAlanlari2;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgvKisiGoster;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblMedHal;
        private System.Windows.Forms.Label lblil;
        private System.Windows.Forms.Label lblilce;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnUstKategori;
    }
}