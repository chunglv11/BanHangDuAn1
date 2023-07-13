using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class MauSacResponsitory : IMauSacResponsitory
    {
        private ShopContext _shopContext;


        public MauSacResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public List<MauSac> GetAll()
        {
            return _shopContext.MauSacs.ToList();
        }
        public MauSac Getbyid(Guid id)
        {
            return _shopContext.MauSacs.FirstOrDefault(c => c.ID == id);
        }
        public bool AddMauSacFromDb(MauSac obj)
        {
            try
            {
                _shopContext.MauSacs.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateMauSacFromDb(MauSac obj)
        {
            try
            {
                if (obj == null) return false;
                var temproducter = _shopContext.MauSacs.FirstOrDefault(p => p.ID == obj.ID);
                temproducter.Ma = obj.Ma;
                temproducter.Ten = obj.Ten;
                temproducter.TrangThai = obj.TrangThai;
                _shopContext.MauSacs.Update(temproducter);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeleteMauSacFromDb(MauSac obj)
        {
            try
            {
               if (obj == null) return false;
            var temproducter = _shopContext.MauSacs.FirstOrDefault(p=>p.ID ==obj.ID);  
            _shopContext.MauSacs.Remove(temproducter);
            _shopContext.SaveChanges();
            return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
