using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ThongKeVM
    {
        
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string SDT { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal GiaNhap { get; set; }

        public ThongKeVM(string maSp, string tenSp, int soLuong, decimal donGia, decimal thanhTien, string sDT, DateTime ngayTao, decimal giaNhap)
        {
            MaSp = maSp;
            TenSp = tenSp;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
            SDT = sDT;
            NgayTao = ngayTao;
            GiaNhap = giaNhap;
        }

    }
}
