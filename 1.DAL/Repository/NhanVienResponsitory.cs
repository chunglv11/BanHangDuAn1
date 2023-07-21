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
      
        public bool add(NhanVien nhanVien)
        {
            try
            {
                _shopContext.NhanViens.Add(nhanVien);
                _shopContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool delete(NhanVien nhanVien)
        {

            try
            {

                var Nhan_Vien = _shopContext.NhanViens.FirstOrDefault(c => c.ID ==nhanVien.ID); // Sửa đổi Guid thành id
                if (Nhan_Vien != null)
                {
                    _shopContext.NhanViens.Remove(nhanVien);
                    _shopContext.SaveChanges();
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

        public List<NhanVien> GetAll()
        {
            return _shopContext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            return _shopContext.NhanViens.Find(id);
        }

        public NhanVien GetByMa(string ma)
        {
            return _shopContext.NhanViens.Find(ma);
        }

        public bool update(NhanVien nhanVien)
        {
            try
            {

                var Nhan_Vien = _shopContext.NhanViens.FirstOrDefault(c => c.ID == nhanVien.ID); // Sửa đổi Guid thành id
                if (Nhan_Vien != null)
                {
                    _shopContext.NhanViens.Update(nhanVien);
                    _shopContext.SaveChanges();
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
       

    }
}
