﻿using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class PhuongThucThanhToanResponsitory : IPhuongThucThanhToanResponsitory
    {
        ShopContext _context;
        public PhuongThucThanhToanResponsitory()
        {
            _context = new ShopContext();
        }
        public bool AddThanhToan(PhuongThucThanhToan obj)
        {
            try
            {
                _context.PhuongThucThanhToans.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteThanhToan(PhuongThucThanhToan obj)
        {
            try
            {
                var thanh_toan = _context.PhuongThucThanhToans.FirstOrDefault(c => c.ID == obj.ID);
                _context.PhuongThucThanhToans.Remove(thanh_toan);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditThanhToan(PhuongThucThanhToan obj)
        {
            try
            {

                _context.PhuongThucThanhToans.Update(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<PhuongThucThanhToan> GetAllThanhToan()
        {
            return _context.PhuongThucThanhToans.ToList();
        }

    }
}
