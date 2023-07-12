using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonServices
    {
        public bool AddHoaDon(HoaDon obj);
        public bool UpdateHoaDon(HoaDon obj);
        public bool DeleteHoaDon(HoaDon obj);
        public List<HoaDon> GetAllHoaDon();
        public List<HoaDonVM> GetAllHoaDonVM();
        public HoaDon GetHoaDonById(Guid id);

    }
}
