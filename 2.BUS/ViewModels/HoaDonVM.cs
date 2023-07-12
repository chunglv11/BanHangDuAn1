using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonVM
    {
        public Guid ID { get; set; }
        public Guid IDKH { get; set; }
        public Guid IDNV { get; set; }
        public Guid IDKM { get; set; }

        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        //View KM
        public string TenKM { get; set; }
        public int? PhanTramGiam { get; set; }
        public int? SoTienGiam { get; set; }
        //View NV
        public string MaNv { get; set; }
        public string HoTenNV { get; set; }
        //View KH
        public string SDTKH { get; set; }

        //public DateTime? NgayShip { get; set; }
        //public DateTime? NgayNhan { get; set; }
        //public string? TenNguoiNhan { get; set; }
        //public string? DiaChi { get; set; }
        //public string? SDT { get; set; }
        public int TrangThai { get; set; }
    }
}
