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
    public class IletisimController
    {
        IRepository<Iletisim> _ki;
        IUnitOfWork _uow;
        public static int iletisimID;
        public static int iletisimGuncelleID;

        public IletisimController()
        {
            _ki = Resource.UOW.GetRepository<Iletisim>();
            _uow = Resource.UOW;
        }

        public List<IletisimDTO> IletisimGetir(int id)
        {
            List<Iletisim> ıletisims = _ki.GetList(x => x.IletisimID==id);
            return EntityToDto(ıletisims);
        }

        private IletisimDTO EntityToDto(Iletisim entity)
        {
            IletisimDTO dto = new IletisimDTO
            {
                IletisimID=entity.IletisimID,
                Adres = entity.Adres,
                E_mail = entity.E_mail,
                IlceID = entity.IlceID,
                SehirID = entity.SehirID,
                Telefon = entity.Telefon,
            };
            return dto;
        }

        private List<IletisimDTO> EntityToDto(List<Iletisim> entityList)
        {
            List<IletisimDTO> dtoList = new List<IletisimDTO>();
            foreach (var entity in entityList)
            {
                IletisimDTO dto = EntityToDto(entity);
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public void IletisimKaydet(IletisimDTO iDTO)
        {
            Iletisim iletisim = new Iletisim()
            {
                Adres = iDTO.Adres,
                E_mail = iDTO.E_mail,
                IlceID = iDTO.IlceID,
                SehirID = iDTO.SehirID,
                Telefon = iDTO.Telefon,
            };
            _ki.Add(iletisim);
            _uow.Save();
            iletisimID = iletisim.IletisimID;
        }
        public void IletisimGuncelle(IletisimDTO iDTO)
        {
            Iletisim guncelle = new Iletisim()
            {
                Adres = iDTO.Adres,
                E_mail = iDTO.E_mail,
                IlceID = iDTO.IlceID,
                SehirID = iDTO.SehirID,
                Telefon = iDTO.Telefon,
            };
            _ki.Update(guncelle);
            _uow.Save();
            iletisimGuncelleID = guncelle.IletisimID;
        }
    }
}
