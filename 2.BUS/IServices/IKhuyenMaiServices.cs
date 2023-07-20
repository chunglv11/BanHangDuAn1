using _1.DAL.Models;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IKhuyenMaiServices
    {
        bool Add(KhuyenMai obj);
        bool Update(KhuyenMai obj);
        bool Delete(KhuyenMai obj);
        List<KhuyenMai> GetAll();
        KhuyenMai? GetByMa(string? ma);

        bool CheckMa(string ma);
        List<KhuyenMaiVM> GetAllView();
    }
}
