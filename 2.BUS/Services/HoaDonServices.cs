using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonResponsitory _iHoaDonRp;
        private IKhachHangResponsitory _iKhachHangRp;
        private IKhuyenMaiResponsitory _iKhuyenMaiRp;
        private INhanVienResponsitory _iNhanVienRp;
        private ShopContext _shopContext;
        public HoaDonServices()
        {
            _iHoaDonRp = new HoaDonResponsitory();
            _iKhachHangRp = new KhachHangResponsitory();
            _iKhuyenMaiRp = new KhuyenMaiResponsitory();
            _iNhanVienRp = new NhanVienResponsitory();
            _shopContext = new ShopContext();
        }
        public bool AddHoaDon(HoaDon obj)
        {
            try
            {

                _iHoaDonRp.AddHoaDonFromdb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDon(HoaDon obj)
        {
            try
            {
                _iHoaDonRp.DeleteHoaDonFromdb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _iHoaDonRp.GetAllHoaDonFromdb();
        }

        public List<HoaDonVM> GetAllHoaDonVM()
        {
            var lst = from a in _shopContext.HoaDons
                      join b in _shopContext.KhachHangs on a.IDKH equals b.ID
                      join c in _shopContext.NhanViens on a.IDNV equals c.ID
                      join d in _shopContext.KhuyenMais on a.IDKM equals d.ID
                      select new HoaDonVM
                      {
                          ID = a.ID,
                          IDKH = b.ID,
                          IDNV = c.ID,
                          IDKM = d.ID,
                          Ma = a.Ma,
                          NgayTao = a.NgayTao,
                          NgayThanhToan = a.NgayThanhToan,
                          TenKM = d.Ten,
                          PhanTramGiam = d.PhanTramGiam,
                          SoTienGiam = d.SoTienGiam,
                          MaNv = c.MaNv,
                          HoTenNV = c.HoTen,
                          SDTKH = b.SDT,
                          TrangThai = a.TrangThai
                      };
            return lst.ToList();
        }

        public HoaDon GetHoaDonById(Guid id)
        {
            return _iHoaDonRp.GetHoaDonById(id);
        }

        public bool UpdateHoaDon(HoaDon obj)
        {
            try
            {
                _iHoaDonRp.UpdateHoaDonFromdb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
