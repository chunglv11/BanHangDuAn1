using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class KhuyenMai
    {
        public Guid ID { get; set; }

        public string Ma { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public int? PhanTramGiam { get; set; }
        public float? SoTienGiam { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<HoaDon> hoaDons { get; set; }
    }
}
