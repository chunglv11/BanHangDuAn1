using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IPhuongThucThanhToanServices
    {
        bool AddThanhToan(PhuongThucThanhToan obj);
        bool EditThanhToan(PhuongThucThanhToan obj);
        bool DeleteThanhToan(PhuongThucThanhToan obj);

        List<PhuongThucThanhToan> GetAllThanhToan();
<<<<<<< Updated upstream
=======
        //List<PhuongThucThanhToan> GetById(Guid Id);

>>>>>>> Stashed changes
    }
}
