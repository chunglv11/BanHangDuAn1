using _2.BUS.IServices;
using _1.DAL.Models;
using _1.DAL.IRepository;
using _1.DAL.Repository;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        public IKhuyenMaiResponsitory igKm;

        public KhuyenMaiServices()
        {
            igKm = new KhuyenMaiResponsitory();
        }
        public bool Add(KhuyenMai obj)
        {
            //add
            return igKm.Add(obj);
        }

        public bool Update(KhuyenMai obj)
        {
            //update
            return igKm.Update(obj);
        }

        public bool Delete(KhuyenMai obj)
        {
            //delete
            return igKm.Delete(obj);
        }

        public List<KhuyenMai> GetAll()
        {
            //GetAll
            return igKm.GetAll();
        }

        public KhuyenMai? GetByMa(string? ma)
        {
            //GetByMa
            return igKm.GetAll().Find(c => c.Ma == ma);
        }

        public bool CheckMa(string ma)
        {
            //checkma

            return !igKm.GetAll().Any(c => c.Ma == ma);
        }

        public List<KhuyenMaiVM> GetAllView()
        {
            // getall
            List<KhuyenMaiVM> lst = (from a in igKm.GetAll()
                                     select new KhuyenMaiVM()
                                     {
                                         KhuyenMai = a,
                                     }).ToList();
            return lst;
        }

        public KhuyenMai GetKhuyenByName(string? name)
        {
            return igKm.GetKhuyenByName(name);
        }
    }
}
