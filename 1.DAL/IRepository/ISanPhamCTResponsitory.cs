using _1.DAL.Models;
using _1.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface ISanPhamCTResponsitory
    {
        public bool AddSanPhamCTFromDb(SanPhamChiTiet obj);

        public bool DeleteSanPhamCTFromDb(Guid id);

        public bool UpdateSanPhamCTFromDb(SanPhamChiTiet obj);

        public List<SanPhamChiTiet> GetAllSanPhamCTFromDb();
        public SanPhamChiTiet GetSanPhamCTByidFromDb(Guid id);
    }
}
