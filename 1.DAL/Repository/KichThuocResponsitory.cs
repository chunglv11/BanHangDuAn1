using _1.DAL.IRepository;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class KichThuocResponsitory : IKichThuocResponsitory
    {
        private ShopContext _shopContext;

        public KichThuocResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public List<KichThuoc> GetAll()
        {
            return _shopContext.Sizes.ToList();
        }
        public KichThuoc Getbyid(Guid id)
        {
            return _shopContext.Sizes.FirstOrDefault(c => c.ID == id);
        }
        public bool AddKichThuocFromDb(KichThuoc obj)
        {
            try
            {

                _shopContext.Sizes.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateKichThuocFromDb(KichThuoc obj)
        {
            if (obj == null) return false;
            var temsize = _shopContext.Sizes.FirstOrDefault(p => p.ID == obj.ID);
            temsize.Ma = obj.Ma;
            temsize.Ten = obj.Ten;
            temsize.TrangThai = obj.TrangThai;
            _shopContext.Sizes.Update(temsize);
            _shopContext.SaveChanges();
            return true;
        }
        public bool DeleteKichThuocFromDb(KichThuoc obj)
        {
            try
            {
                if (obj == null) return false;
                var temsize = _shopContext.Sizes.FirstOrDefault(p => p.ID == obj.ID);
                _shopContext.Sizes.Remove(temsize);
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
