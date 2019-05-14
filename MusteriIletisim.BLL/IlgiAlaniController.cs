using Core.DataAccess;
using MusteriIletisim.DAL;
using MusteriIletisim.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIletisim.BLL
{
    public class IlgiAlaniController
    {            
        IRepository<IlgiAlanlari> _ia;
        IUnitOfWork _uow;
        IRepository<KisiIlgi> _ki;
        public IlgiAlaniController()
        {
            _ia = Resource.UOW.GetRepository<IlgiAlanlari>();
            _ki = Resource.UOW.GetRepository<KisiIlgi>();
            _uow = Resource.UOW;
        }
        public List<IlgiAlanlariDTO> UstIlgiAlanlari()
        {
            
            List<IlgiAlanlari> ilgialani = _ia.GetList(x => x.UstKategori == null);
            return EntityToDto(ilgialani);
        }

        public List<IlgiAlanlariDTO> AltIlgiAlani(int ilgiID)
        {
           
            List<IlgiAlanlari> ilgialani = _ia.GetList(x => x.UstKategori == ilgiID);
            return EntityToDto(ilgialani);
        }

        public IQueryable<int?> UstKategoriGetir(int id)
        {

            var sorgu = (from p in _ia.GetQuery(p => p.IlgiAlaniID==id)                        
                         select p.UstKategori);

            return sorgu;
        }

        public void IlgiAlaniKaydet(List<IlgiAlanlariDTO> ilgiList)
        {
            foreach (var item in ilgiList)
            {
                KisiIlgi kisiIlgi = new KisiIlgi()
                {
                    IlgiAlaniID = item.IlgiAlaniID,
                    KisiID = KisiController.kaydedilenKisiID,
                };
                _ki.Add(kisiIlgi);
                _uow.Save();
            }
            
            
        }

        private IlgiAlanlariDTO EntityToDto(IlgiAlanlari entity)
        {
            IlgiAlanlariDTO dto = new IlgiAlanlariDTO
            {
                IlgiAlaniID = entity.IlgiAlaniID,
                IlgiAlaniAdi = entity.IlgiAlaniAdi,
                UsteKategori = entity.UstKategori
            };
            return dto; 
        }

        private List<IlgiAlanlariDTO> EntityToDto(List<IlgiAlanlari> entityList)
        {
            List<IlgiAlanlariDTO> dtoList = new List<IlgiAlanlariDTO>();
            foreach (var entity in entityList)
            {
                IlgiAlanlariDTO dto = EntityToDto(entity);
                dtoList.Add(dto);
            }
            return dtoList;
        }

         
    }
}
