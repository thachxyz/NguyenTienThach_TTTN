using DAO.Entity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using X.PagedList;

namespace DAO.Service
{
    public class ProductService 
    {
        private readonly TienThachContext _context;

        public ProductService() { 
            _context = new TienThachContext();
        }

        public void delete(long id)
        {
            var entity = _context.Products.Include(e=>e.Images).FirstOrDefault(e => e.Id == id);

            _context.Products.Remove(entity);
            _context.SaveChanges();
        }

        public Product get(long id)
        {
            return  _context.Products.Include(p => p.Category).Include(p => p.Images).Include(p => p.Brand).FirstOrDefault(e=>e.Id == id);
        }

        public List<Product> getAll()
        {
            return null;
            
        }

        public IPagedList<Product> getPage(int limit = 10,int page=1 )
        {
            
            return _context.Products.Include(p=>p.Category).Include(p => p.Images).Include(p => p.Brand).ToPagedList<Product>(page,limit);
           
        }

        public void save(Product model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
        }

        public void update(Product model)
        {
          var entity =   _context.Products.FirstOrDefault(e=>e.Id == model.Id);
           
            entity.BrandId = model.BrandId;
            entity.Price = model.Price;
            entity.NameProduct = model.NameProduct;
            entity.SalePrice = model.SalePrice;
            _context.SaveChanges();

        }
    }
}
