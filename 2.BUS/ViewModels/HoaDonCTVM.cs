using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonCTVM
    {
        public Guid? IDHD { get; set; }
        public Guid IDSPCT { get; set; }
        public string MaSPCT { get; set; }
        public string MauSac { get; set; }
        public string KichThuoc { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
