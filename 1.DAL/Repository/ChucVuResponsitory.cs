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
            if (chucVu == null)
            {
                return false;
            }
            _shopContext.ChucVus.Add(chucVu);
            _shopContext.SaveChanges();
            return true;

        }

        public bool delete(Guid Id)
        {

            var dtcs = _shopContext.ChucVus.FirstOrDefault(c=>c.ID == Id);
            if( dtcs == null)
            { return false; }
            _shopContext.ChucVus.Remove(dtcs);
            _shopContext.SaveChanges();
            return true;

            
            //try
            //{

            //    var khach_hang = _shopContext.KhachHangs.FirstOrDefault(c => c.ID == chucVu.ID); // Sửa đổi Guid thành id
            //    if (khach_hang != null)
            //    {
            //        _shopContext.KhachHangs.Remove(khach_hang);
            //        _shopContext.SaveChanges();
            //        return true;
            //    }
            //    else
            //    {
            //        return false;

            //    }
            //}
            //    catch (Exception)
            //    {
            //    return false;

            //}

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
            
                var IDc = _shopContext.ChucVus.FirstOrDefault(c => c.ID == chucvu.ID);

                if (IDc == null)
                {
                    return false; // Object with the given ID doesn't exist in the database
                }

                // Update the properties of the retrieved object with the values from the given "chucvu" object
                IDc.Ma = chucvu.Ma;
                IDc.Ten = chucvu.Ten;
                IDc.TrangThai = chucvu.TrangThai;

                _shopContext.SaveChanges(); // Save the changes

                return true; // Update successful
            

        }

       
    }
}
