using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class NhanVienViewModels
    {
        public Guid ID { get; set; }
        public Guid IDCV { get; set; }
        public string Username { get; set; }
        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string? AnhNv { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? MatKhau { get; set; }
        public int TrangThai { get; set; }
       
    }
}
