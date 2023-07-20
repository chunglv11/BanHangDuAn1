using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class KhachHangResponsitory : IKhachHangResponsitory
    {
        ShopContext _context;
        public KhachHangResponsitory()
        {
            _context = new ShopContext();
        }

        public bool AddKhachHang(KhachHang obj)
        {
            try
            {
                _context.KhachHangs.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteKhachHang(KhachHang obj)
        {
            try
            {

                var khach_hang = _context.KhachHangs.FirstOrDefault(c => c.ID == obj.ID); // Sửa đổi Guid thành id
                if (khach_hang != null)
                {
                    _context.KhachHangs.Remove(khach_hang);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {
                return false;

            }
        }




        public bool EditKhachHang(KhachHang obj)
        {
            try
            {
                var khach_hang = _context.KhachHangs.FirstOrDefault(c => c.ID == obj.ID);
                _context.KhachHangs.Update(khach_hang);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return _context.KhachHangs.ToList();
        }
    }
}
