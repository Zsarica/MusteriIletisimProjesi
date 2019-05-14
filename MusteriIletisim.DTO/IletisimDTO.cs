using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.DTO
{
    public class IletisimDTO
    {
        public int IletisimID { get; set; }
        public string E_mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
    }
}
