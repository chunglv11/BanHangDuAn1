using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class KhachHang
    {
        public Guid ID { get; set; }
        public string HovaTen { get; set; }
        public int? Diem { get; set; }
        public string SDT { get; set; }
        public int TrangThai { get; set; }
        public List<HoaDon> hoadon { get; set; }
    }
}
