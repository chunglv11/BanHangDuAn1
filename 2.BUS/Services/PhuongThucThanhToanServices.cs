using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class PhuongThucThanhToanServices : IPhuongThucThanhToanServices
    {
        ShopContext _context;
        IPhuongThucThanhToanResponsitory _phuongThucThanhToanResponsitory;
        public bool AddThanhToan(PhuongThucThanhToan obj)
        {
            _phuongThucThanhToanResponsitory.AddThanhToan(obj);
            return true;
        }

        public bool DeleteThanhToan(PhuongThucThanhToan obj)
        {
            _phuongThucThanhToanResponsitory.DeleteThanhToan(obj);
            return true;
        }

        public bool EditThanhToan(PhuongThucThanhToan obj)
        {
            _phuongThucThanhToanResponsitory.EditThanhToan(obj);
            return true;
        }

        public List<PhuongThucThanhToan> GetAllThanhToan()
        {
            return _phuongThucThanhToanResponsitory.GetAllThanhToan().ToList();
        }
    }

      

        
    }

