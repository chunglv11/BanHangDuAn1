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
    public class KichThuocServices : IKichThuocServices
    {
        private IKichThuocResponsitory sizeAo;
        private List<KichThuocViewModels> lstSizeAo;
        public KichThuocServices()
        {
            sizeAo = new KichThuocResponsitory();
            lstSizeAo = new List<KichThuocViewModels>();
        }
        public Guid IdSize(KichThuocViewModels CL)
        {
            KichThuoc x = new KichThuoc()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (sizeAo.AddKichThuocFromDb(x)) return x.ID;
            else return Guid.Empty;
        }
        public string add(KichThuocViewModels size)
        {
            if (size == null) return "Không Thành Công";
            var temp = sizeAo.Getbyid(size.ID);
            KichThuoc x = new KichThuoc()
            {
                ID = size.ID,
                Ma = size.Ma,
                Ten = size.Ten,
                TrangThai = size.TrangThai
            };
            if (temp == null)
            {
                if (size.Ma != "")
                {
                    if (sizeAo.AddKichThuocFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }

        public List<KichThuocViewModels> GetSizeAo()
        {
            lstSizeAo = (from sz in sizeAo.GetAll()
                         select new KichThuocViewModels
                         {
                             ID = sz.ID,
                             Ma = sz.Ma,
                             Ten = sz.Ten,
                             TrangThai = sz.TrangThai,
                         }).OrderBy(c => c.Ma).ToList();
            return lstSizeAo;
        }

        public string remove(KichThuocViewModels size)
        {
            if (size == null) return "Không Thành Công";
            int a = 0;
            var x = new KichThuoc()
            {
                ID = size.ID
            };
            var list = sizeAo.GetAll();
            foreach (var i in list)
            {
                if (size.ID == i.ID) a++;
            }
            if (sizeAo.DeleteKichThuocFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }

        public string update(KichThuocViewModels size)
        {
            if (size == null) return "Không Thành Công";
            var temp = sizeAo.GetAll().FirstOrDefault(c => c.ID == size.ID);
            KichThuoc x = new KichThuoc()
            {
                ID = size.ID,
                Ma = size.Ma,
                Ten = size.Ten,
                TrangThai = size.TrangThai
            };
            if (size.Ma != "")
            {
                if (temp == null)
                {
                    if (sizeAo.UpdateKichThuocFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (size.ID == x.ID)
                {
                    if (sizeAo.UpdateKichThuocFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }

    }
}
