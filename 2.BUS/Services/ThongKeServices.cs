using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class ThongKeServices : IThongKeServices
    {
        private IHoaDonChiTietServices _hoaDonChiTietServices;
        private IHoaDonServices _hoaDonServices;
        private ISanPhamChiTietServices _sanPhamChiTietServices;
        private ISanPhamServices _sanPhamServices;
        private IKhachHangServices _khachHangServices;
        private List<ThongKeVM> _thongKeVMs;
        public ThongKeServices()
        {
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _hoaDonServices = new HoaDonServices();
            _sanPhamChiTietServices = new SanPhamChiTietServices();
            _sanPhamServices = new SanPhamServices();
            _khachHangServices = new KhachHangServices();
            _thongKeVMs = new List<ThongKeVM>();

            GetLstSpDaBan();
        }
        public List<ThongKeVM> GetLstSpDaBan()
        {
            var lstSpDaBan = (from a in _hoaDonServices.GetAllHoaDon() 
                              join b in _hoaDonChiTietServices.GetAllHDCTVM() on a.ID equals b.IDHD
                              join c in _sanPhamChiTietServices.GetAllSanPhamCT() on b.IDSPCT equals c.ID
                              join d in _sanPhamServices.getlsSpfromDB() on c.IDSP equals d.ID
                              join e in _khachHangServices.GetAllKhachHang() on a.IDKH equals e.ID
                              
                              select new {d.Ma, d.Ten, b.SoLuong, b.DonGia, b.ThanhTien, e.SDT, a.NgayTao}).ToList();
            var _lstfinal = lstSpDaBan.OrderByDescending(c => c.SoLuong).GroupBy(d => d.Ma).
                Select(g => new ThongKeVM(g.Key,
                g.Where(d => d.Ma == g.Key).Select(d => d.Ten).FirstOrDefault(),
                g.Where(d => d.Ma == g.Key).Select(d => d.SoLuong).FirstOrDefault(),
                g.Where(d => d.Ma == g.Key).Select(d => d.DonGia).FirstOrDefault(),   
                g.Where(d => d.Ma == g.Key).Select(d => d.ThanhTien).FirstOrDefault(), 
                g.Where(d=> d.Ma == g.Key).Select(d=>d.SDT).FirstOrDefault(),
                g.Where(d => d.Ma == g.Key).Select(d => d.NgayTao).FirstOrDefault())
                ).ToList();
            return _lstfinal;
        }
    }
}
