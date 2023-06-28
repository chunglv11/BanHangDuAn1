using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISanPhamChiTietServices
    {
        public bool AddSanPhamCT(SanPhamChiTiet obj);

        public bool DeleteSanPhamCT(Guid id);

        public bool UpdateSanPhamCT(SanPhamChiTiet obj);

        public List<SanPhamChiTiet> GetAllSanPhamCT();
        public SanPhamChiTiet GetSanPhamCTByid(Guid id);
    }
}
