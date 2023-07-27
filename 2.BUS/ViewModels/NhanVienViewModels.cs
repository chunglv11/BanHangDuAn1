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
     
        public NhanVien NhanVien { get; set; } = new();
        public ChucVu ChucVu { get; set; } = new();
    }
}
