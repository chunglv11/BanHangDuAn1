using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class LoaiSanPhamResponsitory : ILoaiSanPhamResponsitory
    {
         private ShopContext _shopContext;


        public LoaiSanPhamResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public List<LoaiSanPham> GetAll()
        {
            return _shopContext.LoaiSanPhams.ToList();
        }
        public LoaiSanPham Getbyid(Guid id)
        {
            return _shopContext.LoaiSanPhams.FirstOrDefault(c => c.ID == id);
        }
        public bool AddLoaiSanPhamFromDb(LoaiSanPham obj)
        {
            try
            {
                _shopContext.LoaiSanPhams.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateLoaiSanPhamFromDb(LoaiSanPham obj)
        {
           
            try
            {
                if (obj == null) return false;
                var temproducter = _shopContext.LoaiSanPhams.FirstOrDefault(p => p.ID == obj.ID);
                temproducter.Ma = obj.Ma;
                temproducter.Ten = obj.Ten;
                temproducter.TrangThai = obj.TrangThai;
                _shopContext.LoaiSanPhams.Update(temproducter);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeleteLoaiSanPhamFromDb(LoaiSanPham obj)
        {
           
            try
            {
               if (obj == null) return false;
            var temproducter = _shopContext.LoaiSanPhams.FirstOrDefault(p=>p.ID ==obj.ID);  
            _shopContext.LoaiSanPhams.Remove(temproducter);
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
