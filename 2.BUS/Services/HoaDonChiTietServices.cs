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
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        private IHoaDonChiTietResponsitory _ihoaDonCTRp;
        private ShopContext _shopContext;
        public HoaDonChiTietServices()
        {
            _ihoaDonCTRp = new HoaDonChiTietResponsitory();
            _shopContext = new ShopContext();
        }
        public bool AddHDCT(HoaDonChiTiet obj)
        {
            try
            {

                _ihoaDonCTRp.AddHDCTFromDb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHDCT(HoaDonChiTiet obj)
        {
            try
            {
                _ihoaDonCTRp.DeleteHDCTFromDb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return _ihoaDonCTRp.GetAllHDCTFromDb();
        }

        public List<HoaDonCTVM> GetAllHDCTVM(Guid Idhd)
        {
            var lst = from a in _shopContext.HoaDonChiTiet
                      join b in _shopContext.SanPhamChiTiets on a.IDSPCT equals b.ID
                      join c in _shopContext.SanPhams on b.IDSP equals c.ID
                      join d in _shopContext.HoaDons on a.IDHD equals d.ID
                      where a.IDHD == Idhd
                      select new HoaDonCTVM
                      {
                          IDHD = a.IDHD,
                          IDSPCT = a.IDSPCT,
                          MaSPCT = b.Ma,
                          TenSP = c.Ten,
                          SoLuong = a.SoLuong,
                          DonGia = a.DonGia,
                          ThanhTien = Convert.ToDecimal(a.SoLuong * a.DonGia)
                      };
            return lst.ToList();
        }

        public bool UpdateHDCT(HoaDonChiTiet obj)
        {
            try
            {
                _ihoaDonCTRp.UpdateHDCTFromDb(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
