using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietServices
    {
        public bool AddHDCT(HoaDonChiTiet obj);
        public bool UpdateHDCT(HoaDonChiTiet obj);
        public bool DeleteHDCT(HoaDonChiTiet obj);
        public List<HoaDonChiTiet> GetAllHDCT();
        public List<HoaDonCTVM> GetAllHDCTVM(Guid Idhd);
        public List<HoaDonCTVM> GetAllHDCTVM();
    }
}
