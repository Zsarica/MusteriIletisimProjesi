using Common;
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
    public class KisiController
    {
        IRepository<Kisi> _cr;
        IUnitOfWork _uow;
        public static int kaydedilenKisiID;

        public KisiController()
        {
            _cr = Resource.UOW.GetRepository<Kisi>();
            _uow = Resource.UOW;
        }
        public List<KisiDTO> KisileriGetir(string kisiTc)
        {
            List<Kisi> kisiler = _cr.GetList(x => x.Tc == kisiTc);
            return EntityToDto(kisiler);
        }
        
        public void KisiKaydet(KisiDTO kisiDTO)
        {
            Kisi kisi = new Kisi()
            {
                Ad = kisiDTO.Ad,
                CinsiyetEnum = (byte)kisiDTO.CinsiyetEnum,
                Soyad = kisiDTO.Soyad,
                MedeniHalEnum = (byte)kisiDTO.MedeniHalEnum,
                Tc = kisiDTO.Tc,
                Yas = kisiDTO.Yas,
                IletisimID = IletisimController.iletisimID
                
            };
            _cr.Add(kisi);
            _uow.Save();
            kaydedilenKisiID = kisi.KisiID;
        }

        public void KisiGuncelle(KisiDTO kisiDTO)
        {
            Kisi kisi = new Kisi()
            {
                Ad = kisiDTO.Ad,
                CinsiyetEnum = (byte)kisiDTO.CinsiyetEnum,
                Soyad = kisiDTO.Soyad,
                MedeniHalEnum = (byte)kisiDTO.MedeniHalEnum,
                Tc = kisiDTO.Tc,
                Yas = kisiDTO.Yas,
                IletisimID = IletisimController.iletisimGuncelleID

            };
            _cr.Update(kisi);
            _uow.Save();
        }

        private KisiDTO EntityToDto(Kisi entity)
        {
            KisiDTO dto = new KisiDTO
            {
                KisiID = entity.KisiID,
                Tc = entity.Tc,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                CinsiyetEnum = (CinsiyetEnum)entity.CinsiyetEnum,
                MedeniHalEnum = (MedeniHalEnum)entity.MedeniHalEnum,
                Yas = entity.Yas,
                IletisimID = entity.IletisimID
            };
            return dto;
        }

        private List<KisiDTO> EntityToDto(List<Kisi> entityList)
        {
            List<KisiDTO> dtoList = new List<KisiDTO>();
            foreach (var entity in entityList)
            {
                KisiDTO dto = EntityToDto(entity);
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}
