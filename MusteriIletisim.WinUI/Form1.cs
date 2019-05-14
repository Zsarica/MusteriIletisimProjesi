using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIletisim.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriAra ma = new frmMusteriAra();
            ma.MdiParent = this;
            ma.Show();
        }

        private void mesajAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMesajAt mesajAt = new FormMesajAt();
            mesajAt.MdiParent = this;
            mesajAt.Show();
        }
    }
}
