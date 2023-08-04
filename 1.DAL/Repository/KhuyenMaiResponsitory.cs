using _1.DAL.IRepository;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class KhuyenMaiResponsitory : IKhuyenMaiResponsitory
    {
        private ShopContext _context;
        public KhuyenMaiResponsitory()
        {
            _context = new ShopContext();
        }
        public List<KhuyenMai> GetAll()
        {
            return _context.KhuyenMais.ToList();
        }
        public KhuyenMai? GetById(object id)
        {
            return _context.KhuyenMais.Find(id);
        }
        public bool Add(KhuyenMai obj)
        {
            if (obj == null)
            {
                return false;
            }
            _context.KhuyenMais.Add(obj);
            _context.SaveChanges();
            return true;
        }
        public bool Update(KhuyenMai obj)
        {
            _context = new();
            if (obj == null)
            {
                return false;
            }
            _context.KhuyenMais.Update(obj);
            _context.SaveChanges();
            return true;
        }
        public bool Delete(KhuyenMai obj)
        {
            if (obj == null)
            {
                return false;
            }
            _context.KhuyenMais.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public KhuyenMai GetKhuyenByName(string name)
        {
            return _context.KhuyenMais.FirstOrDefault(p => p.Ten.Contains(name));
        }
    }
}