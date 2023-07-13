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
    public class NXSResponsitory : INXSResponsitory
    {
        private ShopContext _shopContext;


        public NXSResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public List<NSX> GetAll()
        {
            return _shopContext.NSXs.ToList();
        }
        public NSX Getbyid(Guid id)
        {
            return _shopContext.NSXs.FirstOrDefault(c => c.ID == id);
        }
        public bool AddNsxFromDb(NSX obj)
        {
            try
            {
                _shopContext.NSXs.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateNsxFromDb(NSX obj)
        {
             if (obj == null) return false;
            var temproducter = _shopContext.NSXs.FirstOrDefault(p => p.ID == obj.ID);
            temproducter.Ma = obj.Ma;
            temproducter.Ten = obj.Ten;
            temproducter.TrangThai = obj.TrangThai;
            _shopContext.NSXs.Update(temproducter);
            _shopContext.SaveChanges();
            return true;
        }
        public bool DeleteNsxFromDb(NSX obj)
        {
           if (obj == null) return false;
            var temproducter = _shopContext.NSXs.FirstOrDefault(p=>p.ID ==obj.ID);  
            _shopContext.NSXs.Remove(temproducter);
            _shopContext.SaveChanges();
            return true;
        }

    }
}
