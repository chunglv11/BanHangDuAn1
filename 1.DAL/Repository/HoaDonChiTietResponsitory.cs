using _1.DAL.IRepository;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class HoaDonChiTietResponsitory : IHoaDonChiTietResponsitory
    {
        private ShopContext _shopContext;
        public HoaDonChiTietResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddHDCTFromDb(HoaDonChiTiet obj)
        {
            _shopContext.HoaDonChiTiet.Add(obj);
            _shopContext.SaveChanges();
            return true;
        }

        public bool DeleteHDCTFromDb(HoaDonChiTiet obj)
        {

            _shopContext.HoaDonChiTiet.Remove(obj);
            _shopContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAllHDCTFromDb()
        {
            return _shopContext.HoaDonChiTiet.ToList();
        }

        //public HoaDonChiTiet GetHDCTById(Guid id)
        //{
        //    return _shopContext.HoaDonChiTiet.Find(id);
        //}

        public bool UpdateHDCTFromDb(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _shopContext.HoaDonChiTiet.Update(obj);
            _shopContext.SaveChanges();
            return true;
        }
    }
}
