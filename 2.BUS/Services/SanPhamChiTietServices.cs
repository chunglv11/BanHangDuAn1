using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SanPhamChiTietServices : ISanPhamChiTietServices
    {
        private ISanPhamCTResponsitory _iSanPhamCTResponsitory;
        public SanPhamChiTietServices()
        {
            _iSanPhamCTResponsitory = new SanPhamCTResponsitory();
        }
        public bool AddSanPhamCT(SanPhamChiTiet obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSanPhamCT(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SanPhamChiTiet> GetAllSanPhamCT()
        {
            return _iSanPhamCTResponsitory.GetAllSanPhamCTFromDb().ToList();
        }

        public SanPhamChiTiet GetSanPhamCTByid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSanPhamCT(SanPhamChiTiet obj)
        {
            throw new NotImplementedException();
        }
    }
}
