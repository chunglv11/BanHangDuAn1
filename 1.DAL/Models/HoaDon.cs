using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDon
    {

        public Guid ID { get; set; }
        public Guid IDKH { get; set; }
        public Guid IDNV { get; set; }
        public Guid? IDKM { get; set; }

        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string? TenNguoiNhan { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public int TrangThai { get; set; }
        public virtual NhanVien nhanvien { get; set; }
        public virtual KhachHang khachhang { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public List<ChiTietThanhToan> ChiTietThanhToans { get; set; }
        public List<HoaDonChiTiet> hoadonchitiet { get; set; }
    }
}
