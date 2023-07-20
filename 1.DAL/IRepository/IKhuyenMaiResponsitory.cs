using _1.DAL.Models;

namespace _1.DAL.IRepository
{
    public interface IKhuyenMaiResponsitory
    {
        List<KhuyenMai> GetAll();
        KhuyenMai? GetById(object id);
        bool Add(KhuyenMai obj);
        bool Update(KhuyenMai obj);
        bool Delete(KhuyenMai obj);
    }
}
