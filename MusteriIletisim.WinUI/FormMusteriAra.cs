using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriIletisim.BLL;
using MusteriIletisim.DTO;
using MusteriIletisim.WinUI.Helpers;

namespace MusteriIletisim.WinUI
{
    public partial class frmMusteriAra : Form
    {
        KisiController _kc;
        public static List<KisiDTO> _kisiler;

        public frmMusteriAra()
        {
            InitializeComponent();
            _kc = new KisiController();
            _kisiler = new List<KisiDTO>();
            txtTc.KeyPress += Helper.OnlyNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            string TcNo = txtTc.Text;
            _kisiler = _kc.KisileriGetir(TcNo);

            dgvMusteriListesi.DataSource = _kisiler;
        }

        public static int kotrol= 0;
        private void btnMusteriOlustur_Click(object sender, EventArgs e)
        {
            kotrol = 0;
            FormBilgiler formBilgiler = new FormBilgiler();
            formBilgiler.MdiParent = Form1.ActiveForm;
            formBilgiler.Show();
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kotrol=1;
            FormBilgiler formBilgiler = new FormBilgiler();
            //formBilgiler.MdiParent = Form1.ActiveForm;
            formBilgiler.Show();
            //this.Close();

           
        }
    }
}
