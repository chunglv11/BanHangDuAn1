using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IPhuongThucThanhToanResponsitory
    {
<<<<<<< Updated upstream
        

        bool AddThanhToan(PhuongThucThanhToan obj);
        bool EditThanhToan(PhuongThucThanhToan obj);
        bool DeleteThanhToan(PhuongThucThanhToan obj);
        List<PhuongThucThanhToan> GetAllThanhToan();
=======
        bool AddThanhToan(PhuongThucThanhToan obj);
        bool EditThanhToan(PhuongThucThanhToan obj);
        bool DeleteThanhToan(PhuongThucThanhToan obj);  
        List<PhuongThucThanhToan> GetAllThanhToan();
        //List<PhuongThucThanhToan> GetById(Guid Id);
>>>>>>> Stashed changes
    }
}
