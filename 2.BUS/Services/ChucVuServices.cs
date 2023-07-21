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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuResponsitory ChucVuMoi;
        private List<ChucVuViewModels> _ChucVuViewModels;

        public ChucVuServices()
        {
           _ChucVuViewModels = new List<ChucVuViewModels>();
            ChucVuMoi = new ChucVuResponsitory();
        }

        public string Them(ChucVuViewModels chucVuViewModels)
        {
            if (chucVuViewModels == null) return "Không Thành Công";
            var temp = ChucVuMoi.GetById(chucVuViewModels.ID);
            ChucVu x = new ChucVu()
            {
                ID = chucVuViewModels.ID,
                Ma = chucVuViewModels.Ma,
                Ten = chucVuViewModels.Ten,
                TrangThai = chucVuViewModels.TrangThai
            };
            if (temp == null)
            {
                if(chucVuViewModels.Ma != "")
                {
                    if (ChucVuMoi.add(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }
        public string Sua(ChucVuViewModels chucVuViewModels)
        {
            if (chucVuViewModels == null) return "Không Thành Công";
            var temp = ChucVuMoi.GetAll().FirstOrDefault(c => c.ID == chucVuViewModels.ID);
            ChucVu x = new ChucVu()
            {
                ID = chucVuViewModels.ID,
                Ma = chucVuViewModels.Ma,
                Ten = chucVuViewModels.Ten,
                TrangThai = chucVuViewModels.TrangThai
            };
            if (chucVuViewModels.Ma != "")
            {
                if (temp  == null)
                {
                    if (ChucVuMoi.update(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (chucVuViewModels.ID == x.ID)
                {
                    if (ChucVuMoi.update(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";

        }

        public string Xoa(Guid Id)
        {
            if (Id == null) return "Không Thành Công";
            int a = 0;
            var x = new ChucVu()
            {
                ID = Id
            };
            var list = ChucVuMoi.GetAll();

            foreach (var i in list)
            {
                if (Id == i.ID) a++;
            }
            if (ChucVuMoi.delete(x)) return "Xóa Thành Công";
            return "thất bại";
            //return "Không Thành Công";
        }




     



        //public ChucVu GetByMa(string ma)
        //{
        //    return GetAll().FirstOrDefault(c => c.Ma == ma);
        //}

       

        

        //public ChucVu GetById(Guid id)
        //{
        //    return GetAll().FirstOrDefault(c => c.ID == id);
        //}

        public List<ChucVuViewModels> Getlst()
        {
            return (from a in ChucVuMoi.GetAll()
                    select new ChucVuViewModels
                    {
                        ID = a.ID,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai
                    }).ToList();
        }
    }
}
