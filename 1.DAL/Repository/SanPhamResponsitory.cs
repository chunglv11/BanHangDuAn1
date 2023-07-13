using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class SanPhamResponsitory : ISanPhamResponsitory
    {
        private ShopContext _shopContext;

        public SanPhamResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public List<SanPham> GetAll()
        {
            return _shopContext.SanPhams.ToList();
        }
        public SanPham Getbyid(Guid id)
        {
            return _shopContext.SanPhams.FirstOrDefault(c => c.ID == id);
        }
        public bool AddSanPhamFromDb(SanPham obj)
        {
            try
            {
                _shopContext.SanPhams.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateSanPhamFromDb(SanPham obj)
        {
            try
            {
               if (obj == null) return false;
                var temproducter = _shopContext.SanPhams.FirstOrDefault(p => p.ID == obj.ID);
                temproducter.Ma = obj.Ma;
                temproducter.Ten = obj.Ten;
                temproducter.TrangThai = obj.TrangThai;
                _shopContext.SanPhams.Update(temproducter);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeleteSanPhamFromDb(SanPham obj)
        {
            try
            {
                 if (obj == null) return false;
            var temproducter = _shopContext.SanPhams.FirstOrDefault(p=>p.ID ==obj.ID);  
            _shopContext.SanPhams.Remove(temproducter);
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
