using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface ILoaiSanPhamResponsitory
    {
        public bool AddLoaiSanPhamFromDb(LoaiSanPham obj);
        public bool UpdateLoaiSanPhamFromDb(LoaiSanPham obj);
        public bool DeleteLoaiSanPhamFromDb(LoaiSanPham obj);
        public List<LoaiSanPham> GetAll();
        public LoaiSanPham Getbyid(Guid id);
    }
}
