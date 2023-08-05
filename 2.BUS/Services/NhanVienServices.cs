using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;


using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly INhanVienResponsitory _NhanVien;

        private List<NhanVienViewModels> _NhanVienViewModels;
        private List<ChucVuViewModels> _ChucVuViewModels;
        private readonly ChucVuResponsitory _ChucVu;
        ShopContext context = new ShopContext();

        //public NhanVienServices()
        //{
        //    _NhanVienViewModels =new List<NhanVienViewModels>();

        //private List<NhanVienResponsitory> _NhanVienViewModels;
        //private List<ChucVuResponsitory> _ChucVu;
        //ShopContext _shopContext = new ShopContext();

        public NhanVienServices()
        {
            _NhanVienViewModels = new List<NhanVienViewModels>();
            _ChucVuViewModels = new List<ChucVuViewModels>();
            _NhanVien = new NhanVienResponsitory();
            _ChucVu = new ChucVuResponsitory();
        }



        public bool Add(NhanVien nhanvien)
        {
            try
            {
                 _NhanVien.add(nhanvien);
                return true;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine($"An error occurred while adding the NhanVien: {ex.Message}");
                return false;
            }
        }

        public bool Update(NhanVien nhanvien)
        {
            return _NhanVien.update(nhanvien);
        }

        public bool Delete(Guid Id)
        {
            return _NhanVien.delete(Id);
        }

        List<NhanVien> INhanVienServices.GetAll()
        {
            return _NhanVien.GetAll();
        }

        NhanVien? INhanVienServices.GetByMa(string? ma)
        {
            return _NhanVien.GetAll().Find(c => c.MaNv == ma);
        }

        public List<NhanVienViewModels> GetAllView()
        {
            List<NhanVienViewModels> lst = (from a in _NhanVien.GetAll()
                                            join b in _ChucVu.GetAll() on a.IDCV equals b.ID
                                            select new NhanVienViewModels()
                                            {
                                                ID = a.ID,
                                                IDCV = a.IDCV,
                                                Username = a.Username,
                                                MaNv = a.MaNv,
                                                HoTen = a.HoTen,
                                                GioiTinh = a.GioiTinh,
                                                Email = a.Email,
                                                AnhNv = a.AnhNv,
                                                NgaySinh = a.NgaySinh,
                                                MatKhau = a.MatKhau,
                                                TrangThai = a.TrangThai,
                                                Ten = b.Ten
                                            }).ToList();
            return lst;
        }

        public bool CheckMa(string ma)
        {
            return !_ChucVu.GetAll().Any(c => c.Ma == ma);
        }
    }


}
