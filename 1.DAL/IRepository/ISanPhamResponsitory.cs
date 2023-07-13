using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface ISanPhamResponsitory
    {
        public bool AddSanPhamFromDb (SanPham obj);
        public bool UpdateSanPhamFromDb (SanPham obj);
        public bool DeleteSanPhamFromDb (SanPham obj);
        public SanPham Getbyid(Guid id);
        public List<SanPham> GetAll();
    }
}
