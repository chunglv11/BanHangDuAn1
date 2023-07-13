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
    public class SanPhamServices : ISanPhamServices
    {
        private ISanPhamResponsitory iSanPham;
        private List<SanPhamViewModels> sanPhamVmd;

        public SanPhamServices()
        {
            iSanPham = new SanPhamResponsitory();
            sanPhamVmd = new List<SanPhamViewModels>();
        }
        public Guid IdSanPham(NsxViewModels CL)
        {
            SanPham x = new SanPham()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (iSanPham.AddSanPhamFromDb(x)) return x.ID;
            else return Guid.Empty;
        }
        public List<SanPhamViewModels> getlsSpfromDB()
        {
            return (from a in iSanPham.GetAll()
                    select new SanPhamViewModels
                    {
                        ID = a.ID,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai
                    }).ToList();
        }

        public string add(SanPhamViewModels Sp)
        {
            if (Sp == null) return "Không Thành Công";
            var temp = iSanPham.Getbyid(Sp.ID);
            SanPham x = new SanPham()
            {
                ID = Sp.ID,
                Ma = Sp.Ma,
                Ten = Sp.Ten,
                TrangThai = Sp.TrangThai
            };
            if (temp == null)
            {
                if (Sp.Ma != "")
                {
                    if (iSanPham.AddSanPhamFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }

        public string update(SanPhamViewModels Sp)
        {
            if (Sp == null) return "Không Thành Công";
            var temp = iSanPham.GetAll().FirstOrDefault(c => c.ID == Sp.ID);
            SanPham x = new SanPham()
            {
                ID = Sp.ID,
                Ma = Sp.Ma,
                Ten = Sp.Ten,
                TrangThai = Sp.TrangThai
            };
            if (Sp.Ma != "")
            {
                if (temp == null)
                {
                    if (iSanPham.UpdateSanPhamFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (Sp.ID == x.ID)
                {
                    if (iSanPham.UpdateSanPhamFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }


        public string remove(SanPhamViewModels Sp)
        {
            if (Sp == null) return "Không Thành Công";
            int a = 0;
            var x = new SanPham()
            {
                ID = Sp.ID
            };
            var list = iSanPham.GetAll();
            foreach (var i in list)
            {
                if (Sp.ID == i.ID) a++;
            }
            if (iSanPham.DeleteSanPhamFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }
    }
}

