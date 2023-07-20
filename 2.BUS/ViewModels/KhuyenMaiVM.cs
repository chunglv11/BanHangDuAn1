using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class KhuyenMaiVM
    {
        public KhuyenMai KhuyenMai { get; set; } = new();
        public HoaDon HoaDon { get; set; } = new();
    }
}
