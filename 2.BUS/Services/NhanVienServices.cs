using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly INhanVienResponsitory NhanVienMoi;
        private List<NhanVienViewModels> _NhanVienViewModels;
        ShopContext context = new ShopContext();

        public NhanVienServices()
        {
            _NhanVienViewModels =new List<NhanVienViewModels>();
            NhanVienMoi = new NhanVienResponsitory();
        }

       
        public List<NhanVien> GetAll()
        {
            return NhanVienMoi.GetAll().ToList();
        }

        public NhanVien GetById(Guid Id)
        {
            return NhanVienMoi.GetById(Id);
        }

       

        public NhanVien GetByMa(string ma)
        {
            return GetAll().FirstOrDefault(c => c.MaNv == ma);
        }

        public string Xoa(Guid Id)
        {
            if (Id == null) return "Không Thành Công";
            int a = 0;
            var x = new NhanVien()
            {
                ID = Id
            };
            var list = NhanVienMoi.GetAll();

            foreach (var i in list)
            {
                if (Id == i.ID) a++;
            }
            if (NhanVienMoi.delete(x)) return "Xóa Thành Công";
            return "thất bại";
        }

        public string Them(NhanVienViewModels nhanVienViewModels)
        {
            if (nhanVienViewModels == null) return "Không Thành Công";
            var temp = NhanVienMoi.GetById(nhanVienViewModels.ID);
            NhanVien x = new NhanVien()
            {
                ID = nhanVienViewModels.ID,
                IDCV = nhanVienViewModels.IDCV,
                Username = nhanVienViewModels.Username,
                MaNv = nhanVienViewModels.MaNv,
                HoTen = nhanVienViewModels.HoTen,
                GioiTinh = nhanVienViewModels.GioiTinh,
                Email = nhanVienViewModels.Email,
                AnhNv = nhanVienViewModels.AnhNv,
                NgaySinh = nhanVienViewModels.NgaySinh,
                MatKhau = nhanVienViewModels.MatKhau,
                TrangThai = nhanVienViewModels.TrangThai
       
    };
            if (temp == null)
            {
                if (nhanVienViewModels.MaNv != "")
                {
                    if (NhanVienMoi.add(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }

        public string Sua(NhanVienViewModels nhanVienViewModels)
        { //         public Guid ID { get; set; }
          //public Guid IDCV { get; set; }
          //public string Username { get; set; }
          //public string MaNv { get; set; }
          //public string HoTen { get; set; }
          //public int GioiTinh { get; set; }
          //public string Email { get; set; }
          //public string? AnhNv { get; set; }
          //public DateTime NgaySinh { get; set; }
          //public string? MatKhau { get; set; }
          //public int TrangThai { get; set; }
            if (nhanVienViewModels == null) return "Không Thành Công";
            var temp = NhanVienMoi.GetAll().FirstOrDefault(c => c.ID == nhanVienViewModels.ID);
            NhanVien x = new NhanVien()
            {
                ID = nhanVienViewModels.ID,
                IDCV = nhanVienViewModels.IDCV,
                Username = nhanVienViewModels.Username,
                MaNv = nhanVienViewModels.MaNv,
                HoTen = nhanVienViewModels.HoTen,
                GioiTinh = nhanVienViewModels.GioiTinh,
                Email = nhanVienViewModels.Email,
                AnhNv = nhanVienViewModels.AnhNv,
                NgaySinh = nhanVienViewModels.NgaySinh,
                MatKhau = nhanVienViewModels.MatKhau,
                TrangThai = nhanVienViewModels.TrangThai
            };
            if (nhanVienViewModels.MaNv != "")
            {
                if (temp == null)
                {
                    if (NhanVienMoi.update(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (nhanVienViewModels.ID == x.ID)
                {
                    if (NhanVienMoi.update(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }
    }
}
