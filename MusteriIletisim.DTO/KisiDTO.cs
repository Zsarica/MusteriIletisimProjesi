using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace MusteriIletisim.DTO
{
    public class KisiDTO
    {
        public int KisiID { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public CinsiyetEnum CinsiyetEnum { get; set; }
        public MedeniHalEnum MedeniHalEnum { get; set; }
        public int Yas { get; set; }
        public int IletisimID { get; set; }
    }
}
