using MusteriIletisim.BLL;
using MusteriIletisim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusteriIletisim.WinUI
{
    public partial class frmIlgiAlani : Form
    {
        IlgiAlaniController _ia;
        List<IlgiAlanlariDTO> _secilenIlgi;
        KisiController _cc;
        IletisimController _ic;
       
        public frmIlgiAlani()
        {
            InitializeComponent();
            _ia = new IlgiAlaniController();
            _secilenIlgi = new List<IlgiAlanlariDTO>();
            _cc = new KisiController();
            _ic = new IletisimController();
        }

        private void frmIlgiAlani_Load(object sender, EventArgs e)
        {
            var IlgiAlaniList = _ia.UstIlgiAlanlari();
            lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
            lstIlgiAlanlari.DataSource = IlgiAlaniList;
        }
               
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstEkliIlgiAlanlari.Items.Contains(lstIlgiAlanlari.SelectedItem))
            {
                MessageBox.Show("Bu ilgi alanını eklediniz..");
                return;
            }
            _secilenIlgi.Add((IlgiAlanlariDTO)lstIlgiAlanlari.SelectedItem);
            
            lstEkliIlgiAlanlariYukle();
        }

        private void lstIlgiAlanlari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int secilenIlgiID = Convert.ToInt32(lstIlgiAlanlari.SelectedValue);
           
            var AltIlgiAlani = _ia.AltIlgiAlani(secilenIlgiID);    
            if(AltIlgiAlani.Count == 0)
            {
                MessageBox.Show("Alt Kategori Bulunmamaktadır");
                return;
            }
            lstIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstIlgiAlanlari.ValueMember = "IlgiAlaniID";
            lstIlgiAlanlari.DataSource = AltIlgiAlani;



        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            
            _secilenIlgi.Remove((IlgiAlanlariDTO)lstEkliIlgiAlanlari.SelectedItem);
            //todo:Bug
            lstEkliIlgiAlanlariYukle();

        }

        private void lstEkliIlgiAlanlariYukle()
        {
            lstEkliIlgiAlanlari.DataSource = null;            
            lstEkliIlgiAlanlari.DisplayMember = "IlgiAlaniAdi";
            lstEkliIlgiAlanlari.ValueMember = "IlgiAlaniID";
            lstEkliIlgiAlanlari.DataSource = _secilenIlgi;
        }

        private void btnUstKategori_Click(object sender, EventArgs e)
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _ic.IletisimKaydet(FormBilgiler._ıletisimDTO);
            _cc.KisiKaydet(FormBilgiler._kisiDTO);
            MessageBox.Show("Müşteri Kaydı Yapılmıştır..");

            _ia.IlgiAlaniKaydet(_secilenIlgi);
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            _ic.IletisimGuncelle(FormBilgiler._ıletisimDTO);
            _cc.KisiGuncelle(FormBilgiler._kisiDTO);
        }
    }
}
