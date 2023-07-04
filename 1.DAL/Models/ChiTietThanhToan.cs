using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ChiTietThanhToan
    {
        public Guid ID { get; set; }
        public Guid IdPhuongThucThanhToan { get; set; }
        public Guid IdHoaDon { get; set; }
        public decimal? SoTienThanhToan { get; set; }
        public string? GhiChu { get; set; }
        public int TrangThai { get; set; }
        public virtual PhuongThucThanhToan phuongThucThanhToan { get; set; }
        public virtual HoaDon hoaDon { get; set; }
    }
}
