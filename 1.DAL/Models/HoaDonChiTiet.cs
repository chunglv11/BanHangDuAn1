using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid ID { get; set; }
        public Guid IDHD { get; set; }
        public Guid IDSPCT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public HoaDon hoadon { get; set; }
        public SanPhamChiTiet sanphamchitiet { get; set; }
    }
}
