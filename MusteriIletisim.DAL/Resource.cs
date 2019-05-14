using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.DAL
{
    public class Resource
    {
        private Resource()
        {

        }
        private static UnitOfWork _uow;
        public static UnitOfWork UOW
        {
            get
            {
                if (_uow == null)
                {
                    _uow = new UnitOfWork(SingletonContext.Context);
                }
                return _uow;
            }
        }
    }
}
