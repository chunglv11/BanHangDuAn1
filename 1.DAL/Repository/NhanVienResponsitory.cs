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

        public bool add(NhanVien nhanvien)
        {
            if (nhanvien == null)
            {
                return false;
            }

            try
            {
                _shopContext.NhanViens.Add(nhanvien);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle or log the exception and inner exception
                Console.WriteLine($"An error occurred while adding the NhanVien: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }



        public bool delete(Guid Id)
        {
            var dtcs = _shopContext.NhanViens.FirstOrDefault(c => c.ID == Id);
            if (dtcs == null)
            { return false; }
            _shopContext.NhanViens.Remove(dtcs);
            _shopContext.SaveChanges();
            return true;
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

        public bool update(NhanVien nhanvien)
        {
            var IDc = _shopContext.NhanViens.FirstOrDefault(c => c.ID == nhanvien.ID);

            if (IDc == null)
            {
                return false; // Object with the given ID doesn't exist in the database
            }

            // Update the properties of the retrieved object with the values from the given "nhanvien" object
            IDc.MaNv = nhanvien.MaNv;
            IDc.HoTen = nhanvien.HoTen;
            IDc.AnhNv = nhanvien.AnhNv;
            IDc.ChucVu = nhanvien.ChucVu;
            //IDc.MatKhau = nhanvien.MatKhau;
            IDc.ID = nhanvien.ID;
            IDc.Email = nhanvien.Email;
            IDc.GioiTinh = nhanvien.GioiTinh;
            IDc.NgaySinh = nhanvien.NgaySinh;
            IDc.Username = nhanvien.Username;
            IDc.TrangThai = nhanvien.TrangThai;

            _shopContext.SaveChanges(); // Save the changes

            return true; // Update successful
        }


    }


}
