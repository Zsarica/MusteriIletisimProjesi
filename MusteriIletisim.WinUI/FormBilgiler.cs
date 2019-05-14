using MusteriIletisim.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using MusteriIletisim.BLL;
using MusteriIletisim.DTO;

namespace MusteriIletisim.WinUI
{
    public partial class FormBilgiler : Form
    {
        IlilceController _bc;
        IletisimController _ic;
        public static IletisimDTO _ıletisimDTO;
        public static KisiDTO _kisiDTO;
        List<IletisimDTO> _iletisimKisiler;

        public FormBilgiler()
        {
            InitializeComponent();
            _bc = new IlilceController();
            _ic = new IletisimController();
            _ıletisimDTO = new IletisimDTO();
            _kisiDTO = new KisiDTO();
            _iletisimKisiler = new List<IletisimDTO>();

            txtAd.KeyPress += Helper.WritingArea;
            txtSoyad.KeyPress += Helper.WritingArea;
            txtTc.KeyPress += Helper.OnlyNumber;
            txtTelefon.KeyPress += Helper.OnlyNumber;
            txtYas.KeyPress += Helper.OnlyNumber;            
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            #region
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                hataMesaji += "Adınızı Giriniz.\n";
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                hataMesaji += "Soaydınızı Giriniz.\n";
            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                hataMesaji += "Mail Adresini Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(txtTc.Text))
            {
                hataMesaji += "TC Kimlik Numarası Giriniz.\n";
            }
            if (string.IsNullOrWhiteSpace(txtYas.Text))
            {
                hataMesaji += "Yaşınızı Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                hataMesaji += "Telefon Numarası Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                hataMesaji += "Cinsiyetinizi Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(cmbMedeniHal.Text))
            {
                hataMesaji += "Medeni Halinizi Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(cmbIl.Text))
            {
                hataMesaji += "İl Bilgisini Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(cmbIlce.Text))
            {
                hataMesaji += "İlçe Bilgisini Giriniz\n";
            }

            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji);
                return;
            }
            #endregion
           

            _ıletisimDTO.Adres = rtxtbxAdres.Text;
            _ıletisimDTO.E_mail = txtMail.Text;
            _ıletisimDTO.IlceID = Convert.ToInt32(cmbIlce.SelectedValue);
            _ıletisimDTO.SehirID = Convert.ToInt32(cmbIl.SelectedValue);
            _ıletisimDTO.Telefon = txtTelefon.Text;

            _kisiDTO.Ad = txtAd.Text;
            _kisiDTO.Soyad = txtSoyad.Text;
            _kisiDTO.Tc = txtTc.Text;
            _kisiDTO.Yas = Convert.ToInt32(txtYas.Text);
            _kisiDTO.CinsiyetEnum = (CinsiyetEnum)cmbCinsiyet.SelectedValue;
            _kisiDTO.MedeniHalEnum = (MedeniHalEnum)cmbMedeniHal.SelectedValue;

            frmIlgiAlani frmIlgi = new frmIlgiAlani();
            frmIlgi.MdiParent = Form1.ActiveForm;
            frmIlgi.Show();
            this.Close();
        }

        private void FormBilgiler_Load(object sender, EventArgs e)
        {
            var illList = _bc.illeriGetir();

            cmbIl.DataSource = illList;
            cmbIl.DisplayMember = "sehir";
            cmbIl.ValueMember = "id";

            var ilceList = _bc.ilceleriGetir(Convert.ToInt32(cmbIl.SelectedValue));

            cmbIlce.DataSource = ilceList;
            cmbIlce.DisplayMember = "ilce";
            cmbIlce.ValueMember = "id";

            cmbCinsiyet.ListControlFill<CinsiyetEnum>();
            cmbMedeniHal.ListControlFill<MedeniHalEnum>();

            int id =0;
            if (frmMusteriAra.kotrol == 1)
            {
                foreach (var item in frmMusteriAra._kisiler)
                {
                    id = item.IletisimID;
                    txtAd.Text = item.Ad;
                    txtSoyad.Text = item.Soyad;
                    txtTc.Text = item.Tc;
                    txtYas.Text = item.Yas.ToString();
                    cmbCinsiyet.SelectedValue = (int)item.CinsiyetEnum;
                    cmbMedeniHal.SelectedValue = (int)item.MedeniHalEnum;
                }

                _iletisimKisiler = _ic.IletisimGetir(id);
                foreach (var item in _iletisimKisiler)
                {
                    txtTelefon.Text = item.Telefon;
                    txtMail.Text = item.E_mail;
                    rtxtbxAdres.Text = item.Adres;
                    cmbIl.SelectedValue = item.SehirID;
                    cmbIlce.SelectedValue = item.IlceID;
                }
            }
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
