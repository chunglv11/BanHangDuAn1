using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class PhuongThucThanhToan
    {
        public Guid ID { get; set; }
        public string MaPTThanhToan { get; set; }
        public string TenPTThanhToan { get; set; }
        public int TrangThai { get; set; }
        public List<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
