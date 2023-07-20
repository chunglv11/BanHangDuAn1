using _1.DAL.IRepository;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class NhanVienResponsitory : INhanVienResponsitory
    {
        ShopContext _shopContext;
        List<NhanVien> _lstnhanViens;

        public NhanVienResponsitory()
        {
            _shopContext = new ShopContext();
            _lstnhanViens = new List<NhanVien>();

        }
      
        public string add(NhanVien nhanVien)
        {
            _shopContext.NhanViens.Add(nhanVien);
            _shopContext.SaveChanges();

            return "Thêm dữ liệu thành công";
        }

        public string delete(NhanVien nhanVien)
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetAll()
        {
            return _shopContext.NhanViens.ToList();
        }

        

        public string update(NhanVien nhanVien)
        {
            _shopContext.NhanViens.Update(nhanVien);
            _shopContext.SaveChanges();

          
            return "Cập nhật dữ liệu thành công";
        }
       

    }
}
