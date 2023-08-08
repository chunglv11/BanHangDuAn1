using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuResponsitory ChucVuMoi;
        private List<ChucVuViewModels> _ChucVuViewModels;
        private List<ChucVu> _ChucVu;

        public ChucVuServices()
        {
           _ChucVuViewModels = new List<ChucVuViewModels>();
            ChucVuMoi = new ChucVuResponsitory();
        }

        public bool Add(ChucVu chucvu)
        {
            return ChucVuMoi.add(chucvu);
        }

        public bool CheckMa(string ma)
        {
            return !ChucVuMoi.GetAll().Any(c => c.Ma == ma);
        }

        public bool Delete(Guid Id)
        {
            return ChucVuMoi.delete(Id);

        }

        public List<ChucVu> GetAll()
        {
            return ChucVuMoi.GetAll();
        }

        public List<ChucVuViewModels> GetAllView()
        {
            List<ChucVuViewModels> lst = (from a in ChucVuMoi.GetAll()
                                     select new ChucVuViewModels()
                                     {
                                         ID = a.ID,
                                         Ma = a.Ma,
                                         Ten = a.Ten,
                                         TrangThai = a.TrangThai,
                                     }).ToList();
            return lst;
        }

        public ChucVu? GetByMa(string? ma)
        {
            return ChucVuMoi.GetAll().Find(c => c.Ma == ma);
        }

        public bool Update(ChucVu chucvu)
        {
            return ChucVuMoi.update(chucvu);
        }
    }
}
