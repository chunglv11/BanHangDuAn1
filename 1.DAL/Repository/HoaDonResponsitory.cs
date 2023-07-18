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
    public class HoaDonResponsitory : IHoaDonResponsitory
    {
        private ShopContext _shopContext;
        public HoaDonResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddHoaDonFromdb(HoaDon obj)
        {
            if (obj == null) return false;

            _shopContext.HoaDons.Add(obj);
            _shopContext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonFromdb(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _shopContext.HoaDons.FirstOrDefault(c => c.ID == obj.ID);
            _shopContext.HoaDons.Remove(temp);
            _shopContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHoaDonFromdb()
        {
            return _shopContext.HoaDons.Include(c => c.khachhang)
                                        .Include(d => d.nhanvien)
                                        .Include(e => e.KhuyenMai)
                .ToList();
        }

        public HoaDon GetHoaDonById(Guid id)
        {
            return _shopContext.HoaDons.Find(id);
        }

        public bool UpdateHoaDonFromdb(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _shopContext.HoaDons.FirstOrDefault(c => c.ID == obj.ID);
            temp.IDKH = obj.IDKH;
            temp.IDNV = obj.IDNV;
            temp.IDKM = obj.IDKM;
            temp.NgayTao = obj.NgayTao;
            temp.NgayThanhToan = obj.NgayThanhToan;
            temp.NgayShip = obj.NgayShip;
            temp.NgayNhan = obj.NgayNhan;
            temp.TenNguoiNhan = obj.TenNguoiNhan;
            temp.DiaChi = obj.DiaChi;
            temp.SDT = obj.SDT;
            temp.TrangThai = obj.TrangThai;
            _shopContext.HoaDons.Update(temp);
            _shopContext.SaveChanges();
            return true;

        }
    }
}
