using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangResponsitory _KhachHangResponsitory;
        ShopContext _context;
        public KhachHangServices()
        {
            _KhachHangResponsitory = new KhachHangResponsitory();
            _context = new ShopContext();

        }



        public bool AddKhachHang(KhachHang obj)
        {
            return _KhachHangResponsitory.AddKhachHang(obj);

        }

        public bool DeleteKhachHang(KhachHang obj)
        {
            _KhachHangResponsitory.DeleteKhachHang(obj);
            return true;
        }

        public bool EditKhachHang(KhachHang obj)
        {
            _KhachHangResponsitory.EditKhachHang(obj);
            return true;
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return _KhachHangResponsitory.GetAllKhachHang().ToList();
        }
    }
}
