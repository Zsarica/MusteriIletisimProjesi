using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.DTO
{
    public class MesajAtDTO
    {
        public int Yas { get; set; }
        public CinsiyetEnum CinsiyetEnum { get; set; }
        public MedeniHalEnum MedeniHalEnum { get; set; }
        public int sehirId { get; set; }
        public int ilceId { get; set; }
    }
}
