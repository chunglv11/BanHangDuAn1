using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISanPhamChiTietServices
    {
        public bool AddSanPhamCT(SanPhamCTViewModels obj);

        public bool DeleteSanPhamCT(Guid id);

        public bool UpdateSanPhamCT(SanPhamCTViewModels obj);
        public List<SanPhamCTViewModels> GetsListCtSp();
        public List<SanPhamChiTiet> GetAllSanPhamCT();
        public SanPhamChiTiet GetSanPhamCTByid(Guid id);
        public Guid IdSp(SanPhamViewModels Sp);
    }
}
