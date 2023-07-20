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
    public class MauSacServices : IMauSacServices
    {
         private IMauSacResponsitory iMauSac;
        private List<MauSacViewModels> mauSacVMd;
        public MauSacServices()
        {
            iMauSac = new MauSacResponsitory();
            mauSacVMd = new List<MauSacViewModels>();
        }
        public Guid IdmauSac(MauSacViewModels CL)
        {
            MauSac x = new MauSac()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (iMauSac.AddMauSacFromDb(x)) return x.ID;
            else return Guid.Empty;
        }
        public string add(MauSacViewModels mauSac)
        {
            if (mauSac == null) return "Không Thành Công";
            var temp = iMauSac.Getbyid(mauSac.ID);
            MauSac x = new MauSac()
            {
                ID = mauSac.ID,
                Ma = mauSac.Ma,
                Ten = mauSac.Ten,
                TrangThai = mauSac.TrangThai
            };
            if (temp == null)
            {
                if (mauSac.Ma != "")
                {
                    if (iMauSac.AddMauSacFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }

        public List<MauSacViewModels> GetMauSac()
        {
            mauSacVMd = (from sz in iMauSac.GetAll()
                         select new MauSacViewModels
                         {
                             ID = sz.ID,
                             Ma = sz.Ma,
                             Ten = sz.Ten,
                             TrangThai = sz.TrangThai,
                         }).OrderBy(c => c.Ma).ToList();
            return mauSacVMd;
        }

        public string remove(MauSacViewModels mauSac)
        {
            if (mauSac == null) return "Không Thành Công";
            int a = 0;
            var x = new MauSac()
            {
                ID = mauSac.ID
            };
            var list = iMauSac.GetAll();
            foreach (var i in list)
            {
                if (mauSac.ID == i.ID) a++;
            }
            if (iMauSac.DeleteMauSacFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }

        public string update(MauSacViewModels mauSac)
        {
            if (mauSac == null) return "Không Thành Công";
            var temp = iMauSac.GetAll().FirstOrDefault(c => c.ID == mauSac.ID);
            MauSac x = new  MauSac()
            {
                ID = mauSac.ID,
                Ma = mauSac.Ma,
                Ten = mauSac.Ten,
                TrangThai = mauSac.TrangThai
            };
            if (mauSac.Ma != "")
            {
                if (temp == null)
                {
                    if (iMauSac.UpdateMauSacFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (mauSac.ID == x.ID)
                {
                    if (iMauSac.UpdateMauSacFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }

    }
}
