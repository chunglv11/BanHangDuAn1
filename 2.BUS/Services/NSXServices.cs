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
    public class NSXServices : INSXServices
    {
        private INXSResponsitory insxrp;
        private List<NsxViewModels> lstNsx;

        public NSXServices()
        {
            insxrp = new NXSResponsitory();
            lstNsx = new List<NsxViewModels>();
        }
        public string add(NsxViewModels nSX)
        {
            if (nSX == null) return "Không Thành Công";
            var temp = insxrp.GetAll().FirstOrDefault(c => c.Ma == nSX.Ma);
            NSX x = new NSX()
            {
                ID = nSX.ID,
                Ma = nSX.Ma,
                Ten = nSX.Ten,
                TrangThai = nSX.TrangThai
            };
            if (temp == null)
            {
                if (nSX.Ma != "")
                {
                    if (insxrp.AddNsxFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }
        public Guid IdSize(NsxViewModels CL)
        {
            NSX x = new NSX()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (insxrp.AddNsxFromDb(x)) return x.ID;
            else return Guid.Empty;
        }
        public List<NsxViewModels> GetNhasanxuat()
        {
            lstNsx = (from nsx in insxrp.GetAll()
                           select new NsxViewModels
                           {
                               ID = nsx.ID,
                               Ma = nsx.Ma,
                               Ten =nsx.Ten,
                               TrangThai = nsx.TrangThai,
                           }).OrderBy(c => c.Ma).ToList();
            return lstNsx;
        }

        public string remove(NsxViewModels NSX)
        {
            if (NSX == null) return "Không Thành Công";
            int a = 0;
            var x = new NSX()
            {
                ID = NSX.ID
            };
            var list = insxrp.GetAll();
            foreach (var i in list)
            {
                if (NSX.ID == i.ID) a++;
            }
            if (insxrp.DeleteNsxFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }

        public string update(NsxViewModels NSX)
        {
            if (NSX == null) return "Không Thành Công";
            var temp = insxrp.Getbyid(NSX.ID);
            NSX x = new NSX()
            {
                ID = NSX.ID,
                Ma = NSX.Ma,
                Ten = NSX.Ten,
                TrangThai = NSX.TrangThai
            };
            if (NSX.Ma != "")
            {
                if (temp == null)
                {
                    if (insxrp.UpdateNsxFromDb(x)) return "Sửa Thành Công";
                    
                    return "Không Thành Công";
                }
                else if (NSX.ID == x.ID)
                {
                    if (insxrp.UpdateNsxFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                    
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }
    
    }
}
