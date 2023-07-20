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
<<<<<<< Updated upstream
        IPhuongThucThanhToanResponsitory _phuongThucThanhToanResponsitory;
=======
         IPhuongThucThanhToanResponsitory _phuongThucThanhToanResponsitory;
        public PhuongThucThanhToanServices()
        {
            _context = new ShopContext();
            _phuongThucThanhToanResponsitory = new PhuongThucThanhToanResponsitory();
            
        }
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        public bool EditThanhToan(PhuongThucThanhToan obj)
        {
            _phuongThucThanhToanResponsitory.EditThanhToan(obj);
            return true;
        }

        public List<PhuongThucThanhToan> GetAllThanhToan()
        {
            return _phuongThucThanhToanResponsitory.GetAllThanhToan().ToList();
        }
<<<<<<< Updated upstream
    }

      

        
    }

=======

        //public List<PhuongThucThanhToan> GetById(Guid Id)
        //{
        //    return _phuongThucThanhToanResponsitory.GetById(Id);
        //}
    }
}
>>>>>>> Stashed changes
