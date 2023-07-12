using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IHoaDonChiTietResponsitory
    {
        public bool AddHDCTFromDb(HoaDonChiTiet obj);
        public bool UpdateHDCTFromDb(HoaDonChiTiet obj);
        public bool DeleteHDCTFromDb(HoaDonChiTiet obj);
        public List<HoaDonChiTiet> GetAllHDCTFromDb();
        //public HoaDonChiTiet GetHDCTById(Guid id);
    }
}
