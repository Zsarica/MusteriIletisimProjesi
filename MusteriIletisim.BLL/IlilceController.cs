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
    public class IlilceController
    {
        IRepository<ilceler> _br;
        IRepository<iller> _cr;
        IUnitOfWork _uow;
        public IlilceController()
        {
            _br = Resource.UOW.GetRepository<ilceler>();
            _cr = Resource.UOW.GetRepository<iller>();
            _uow = Resource.UOW;
        }
        public List<ilDTO> illeriGetir()
        {
            List<iller> iller = _cr.GetList();
            return EntityToDtoIller(iller);
        }
        public List<ilceDTO> ilceleriGetir(int id)
        {
            List<ilceler> ilceler = _br.GetList(x => x.sehir == id);
            return EntityToDtoIlceler(ilceler);
        }
        private ilDTO EntityToDtoIller(iller entity)
        {
            ilDTO dto = new ilDTO
            {
                id = entity.id,
                sehir = entity.sehir
            };
            return dto;
        }
        private List<ilDTO> EntityToDtoIller(List<iller> entityList)
        {
            List<ilDTO> dtoList = new List<ilDTO>();
            foreach (var entity in entityList)
            {
                ilDTO dto = EntityToDtoIller(entity);
                dtoList.Add(dto);
            }
            return dtoList;
        }
        private ilceDTO EntityToDtoIlceler(ilceler entity)
        {
            ilceDTO dto = new ilceDTO
            {
                id = entity.id,
                ilce = entity.ilce,
                sehir = entity.sehir
            };
            return dto;
        }
        private List<ilceDTO> EntityToDtoIlceler(List<ilceler> entityList)
        {
            List<ilceDTO> dtoList = new List<ilceDTO>();
            foreach (var entity in entityList)
            {
                ilceDTO dto = EntityToDtoIlceler(entity);
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}
