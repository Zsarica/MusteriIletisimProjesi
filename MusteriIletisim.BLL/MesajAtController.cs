using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using MusteriIletisim.DAL;
using MusteriIletisim.DTO;

namespace MusteriIletisim.BLL
{
    public class MesajAtController
    {
        IRepository<KisiIlgi> _ki;
        IRepository<Kisi> _ks;
        IRepository<Iletisim> _il;
        IUnitOfWork _uow;

        public MesajAtController()
        {
            _ki = Resource.UOW.GetRepository<KisiIlgi>();
            _ks = Resource.UOW.GetRepository<Kisi>();
            _il = Resource.UOW.GetRepository<Iletisim>();
            _uow = Resource.UOW;
        }

        public List<MesajAtDTO> ListeGetir(int yas, byte cinsiyet,byte medeniHal,int sehirId, int ilceId)
        {
            var sorgu = (from p in _ks.GetQuery(x => x.Yas == yas && x.CinsiyetEnum == cinsiyet && x.MedeniHalEnum == medeniHal)
                         join c in _il.GetQuery(x => x.SehirID == sehirId && x.IlceID == ilceId) on p.IletisimID equals c.IletisimID
                         select new MesajAtDTO()
                         {
                             Yas = p.Yas,
                              sehirId=c.SehirID
                         });

            return sorgu.ToList();
        }
    }
}
