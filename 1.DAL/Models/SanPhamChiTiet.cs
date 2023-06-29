using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class SanPhamChiTiet
    {
        public Guid ID { get; set; }
        public Guid IDKC { get; set; }
        public Guid IDSP { get; set; }
        public Guid IDLOAI { get; set; }
        public Guid IDNSX { get; set; }
        public Guid IDMS { get; set; }

        public string Ma { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string? HinhAnh { get; set; }
        public int TrangThai { get; set; }
        public string MoTa { get; set; }
        public virtual NSX nsx { get; set; }
        public virtual MauSac mausac { get; set; }
        public virtual LoaiSanPham loaiSanPham { get; set; }
        public virtual SanPham sanpham { get; set; }
        public virtual KichThuoc size { get; set; }
        public List<HoaDonChiTiet> hoadonchitiet { get; set; }
    }
}
