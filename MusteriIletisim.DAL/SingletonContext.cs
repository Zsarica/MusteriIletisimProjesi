using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.DAL
{
    class SingletonContext
    {
        private SingletonContext()
        {

        }
        private static MusteriBilgileriDbEntities _context;
        public static MusteriBilgileriDbEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new MusteriBilgileriDbEntities();
                }
                return _context;
            }
        }
    }
}
