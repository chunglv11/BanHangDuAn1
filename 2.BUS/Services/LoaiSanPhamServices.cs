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
    public class LoaiSanPhamServices : ILoaiSanPhamServices
    {
        private ILoaiSanPhamResponsitory iloaiSp;
        private List<PhanLoaiSpViewModels> lstLoaiSp;

        public LoaiSanPhamServices()
        {
            iloaiSp = new LoaiSanPhamResponsitory();
            lstLoaiSp = new List<PhanLoaiSpViewModels>();
        }
        public Guid IdSize(PhanLoaiSpViewModels CL)
        {
            LoaiSanPham x = new LoaiSanPham()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (iloaiSp.AddLoaiSanPhamFromDb(x)) return x.ID;
            else return Guid.Empty;
        }
        public string add(PhanLoaiSpViewModels LSp)
        {
            if (LSp == null) return "Không Thành Công";
            var temp = iloaiSp.Getbyid(LSp.ID);
            LoaiSanPham x = new LoaiSanPham()
            {
                ID = LSp.ID,
                Ma = LSp.Ma,
                Ten = LSp.Ten,
                TrangThai = LSp.TrangThai
            };
            if (temp == null)
            {
                if (LSp.Ma != "")
                {
                    if (iloaiSp.AddLoaiSanPhamFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng mã rồi"; }
        }

        public List<PhanLoaiSpViewModels> GetLoaiSP()
        {
            lstLoaiSp = (from LSp in iloaiSp.GetAll()
                           select new PhanLoaiSpViewModels
                           {
                               ID = LSp.ID,
                               Ma = LSp.Ma,
                               Ten = LSp.Ten,
                               TrangThai = LSp.TrangThai,
                           }).OrderBy(c => c.Ma).ToList();
            return lstLoaiSp;
        }

        public string remove(PhanLoaiSpViewModels LSp)
        {
            if (LSp == null) return "Không Thành Công";
            int a = 0;
            var x = new LoaiSanPham()
            {
                ID = LSp.ID
            };
            var list = iloaiSp.GetAll();
            foreach (var i in list)
            {
                if (LSp.ID == i.ID) a++;
            }
            if (iloaiSp.DeleteLoaiSanPhamFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }

        public string update(PhanLoaiSpViewModels LSp)
        {
            if (LSp == null) return "Không Thành Công";
            var temp = iloaiSp.Getbyid(LSp.ID);
            LoaiSanPham x = new LoaiSanPham()
            {
                ID = LSp.ID,
                Ma = LSp.Ma,
                Ten = LSp.Ten,
                TrangThai = LSp.TrangThai
            };
            if (LSp.Ma != "")
            {
                if (temp == null)
                {
                    if (iloaiSp.UpdateLoaiSanPhamFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (LSp.ID == x.ID)
                {
                    if (iloaiSp.UpdateLoaiSanPhamFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi kìa"; }
            }
            else return "Vui lòng đủ thông tin";
        }

    }
}
