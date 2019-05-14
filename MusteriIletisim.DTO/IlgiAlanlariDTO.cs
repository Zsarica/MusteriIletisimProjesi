using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.DTO
{
    public class IlgiAlanlariDTO
    {
        public int IlgiAlaniID { get; set; }
        public string IlgiAlaniAdi { get; set; }
        public Nullable<int> UsteKategori { get; set; }
    }
}
