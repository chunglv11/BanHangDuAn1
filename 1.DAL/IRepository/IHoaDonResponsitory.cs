using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IHoaDonResponsitory
    {
        public bool AddHoaDonFromdb(HoaDon obj);
        public bool UpdateHoaDonFromdb(HoaDon obj);
        public bool DeleteHoaDonFromdb(HoaDon obj);
        public List<HoaDon> GetAllHoaDonFromdb();
    }
}
