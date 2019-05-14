using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriIletisim.WinUI.Helpers;
using Common;
using MusteriIletisim.BLL;
using MusteriIletisim.DTO;

namespace MusteriIletisim.WinUI
{
    public partial class FormMesajAt : Form
    {
        IlilceController _bc;
        MesajAtController _mc;
        IlgiAlaniController _ia;
        List<IlgiAlanlariDTO> _secilenIlgi;

        public FormMesajAt()
        {
            InitializeComponent();
            _bc = new IlilceController();
            _mc = new MesajAtController();
            _ia = new IlgiAlaniController();
            _secilenIlgi = new List<IlgiAlanlariDTO>();
        }

        private void FormMesajAt_Load(object sender, EventArgs e)
        {
            var illList = _bc.illeriGetir();

            cmbil.DataSource = illList;
            cmbil.DisplayMember = "sehir";
            cmbil.ValueMember = "id";

            var ilceList = _bc.ilceleriGetir(Convert.ToInt32(cmbil.SelectedValue));

            cmbilce.DataSource = ilceList;
            cmbilce.DisplayMember = "ilce";
            cmbilce.ValueMember = "id";

            cmbCinsiyet.ListControlFill<CinsiyetEnum>();
            cmbMedHal.ListControlFill<MedeniHalEnum>();

            var ilgiAlaniList = _ia.UstIlgiAlanlari();
            lstIlgiAlanlari.DataSource = ilgiAlaniList;
            lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
            var list = _mc.ListeGetir(Convert.ToInt32(txtYas.Text), Convert.ToByte(cmbCinsiyet.SelectedValue), Convert.ToByte(cmbMedHal.SelectedValue), Convert.ToInt32(cmbil.SelectedValue), Convert.ToInt32(cmbilce.SelectedValue));
            dgvKisiGoster.DataSource = list;
        }

        private void LstIlgiAlanlari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int secilenIlgiID = Convert.ToInt32(lstIlgiAlanlari.SelectedValue);

            var AltIlgiAlani = _ia.AltIlgiAlani(secilenIlgiID);

            if (AltIlgiAlani.Count == 0)
            {
                MessageBox.Show("Alt Kategori Bulunmamaktadır");
                return;
            }
            lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
            lstIlgiAlanlari.DataSource = AltIlgiAlani;
        }

        private void BtnUstKategori_Click(object sender, EventArgs e)
        {
            int IlgiId = Convert.ToInt32(lstIlgiAlanlari.SelectedValue);

            int UstKategoriID = Convert.ToInt16(_ia.UstKategoriGetir(IlgiId).SingleOrDefault());
            int UstKategoriID2 = Convert.ToInt16(_ia.UstKategoriGetir(UstKategoriID).SingleOrDefault());
            if (UstKategoriID2 == 0)
            {
                var IlgiAlaniList = _ia.UstIlgiAlanlari();
                lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
                lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
                lstIlgiAlanlari.DataSource = IlgiAlaniList;
                return;
            }
            var AltIlgiAlani = _ia.AltIlgiAlani(UstKategoriID2);
            lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
            lstIlgiAlanlari.DataSource = AltIlgiAlani;
        }
        private void lstEkliIlgiAlanlariYukle()
        {
            lstIlgiAlanlari2.DataSource = null;
            lstIlgiAlanlari2.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari2.ValueMember = "IlgiAlaniID";
            lstIlgiAlanlari2.DataSource = _secilenIlgi;
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            if (lstIlgiAlanlari2.Items.Contains(lstIlgiAlanlari.SelectedItem))
            {
                MessageBox.Show("Bu ilgi alanını eklediniz..");
                return;
            }
            _secilenIlgi.Add((IlgiAlanlariDTO)lstIlgiAlanlari.SelectedItem);

            lstEkliIlgiAlanlariYukle();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            _secilenIlgi.Remove((IlgiAlanlariDTO)lstIlgiAlanlari2.SelectedItem);
            //todo:Bug
            lstEkliIlgiAlanlariYukle();
        }
    }
}
