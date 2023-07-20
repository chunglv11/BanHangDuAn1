using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class SanPhamCTViewModels
    {
        public Guid ID { get; set; }
        public Guid? IDKC { get; set; }
        public Guid? IDSP { get; set; }
        public Guid? IDLOAI { get; set; }
        public Guid? IDNSX { get; set; }
        public Guid? IDMS { get; set; }

        public string Ma { get; set; }
        public string? TenSp { get; set; }
        public string? MauSac { get; set; }
        public string? LoaiSp { get; set; }
        public string? Size { get; set; }
        public string? Nsx { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string? HinhAnh { get; set; }
        public int TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}
