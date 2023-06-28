using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class SanPhamCTResponsitory : ISanPhamCTResponsitory
    {
        private ShopContext _shopContext;
        public SanPhamCTResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddSanPhamCTFromDb(SanPhamChiTiet obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSanPhamCTFromDb(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SanPhamChiTiet> GetAllSanPhamCTFromDb()
        {
            return _shopContext.SanPhamChiTiets.ToList();
        }

        public SanPhamChiTiet GetSanPhamCTByidFromDb(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSanPhamCTFromDb(SanPhamChiTiet obj)
        {
            throw new NotImplementedException();
        }
    }
}
