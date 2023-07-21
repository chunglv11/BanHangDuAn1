using _1.DAL.IRepository;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ChucVuResponsitory : IChucVuResponsitory
    {
        ShopContext _shopContext;
        List<ChucVu> _lstchucvus;
        public ChucVuResponsitory()
        {
            _shopContext = new ShopContext();
            _lstchucvus = new List<ChucVu>();

        }


        public bool add(ChucVu chucVu)
        {
            try
            {
                _shopContext.ChucVus.Add(chucVu);
                _shopContext.SaveChanges();

                return true;
            }
            catch (Exception )
            {
                return false;
            }
            
        }

        public bool delete(ChucVu chucVu)
        {

            

                try
                {
                    if (chucVu == null) return false;
                    var x = _shopContext.ChucVus.FirstOrDefault(p => p.ID == chucVu.ID);
                    _shopContext.ChucVus.Remove(x);
                    _shopContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }

            
        }
        //public bool DeleteKhachHang(KhachHang obj)
        //{
        //    try
        //    {

        //        var khach_hang = _context.KhachHangs.FirstOrDefault(c => c.ID == obj.ID); // Sửa đổi Guid thành id
        //        if (khach_hang != null)
        //        {
        //            _context.KhachHangs.Remove(khach_hang);
        //            _context.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;

        //    }
        //}

        public List<ChucVu> GetAll()
        {
            return _shopContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            return _shopContext.ChucVus.Find(id);
        }

        public ChucVu GetByMa(string ma)
        {
            return _shopContext.ChucVus.Find(ma);
        }

        public bool update(ChucVu chucvu)
        {
            
            try
            {

                var Chuc_Vu = _shopContext.ChucVus.FirstOrDefault(c => c.Ma == chucvu.Ma); // Sửa đổi Guid thành id
                if (Chuc_Vu != null)
                {
                    _shopContext.ChucVus.Update(Chuc_Vu);
                    _shopContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {
                return false;

            }
        }

        
    }
}
