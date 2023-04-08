using DAO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Service
{
    public class BrandService
    {
        private readonly TienThachContext _context;

        public BrandService()
        {
            _context = new TienThachContext();
        }

        public List<Brand> GetAll()
        {
           return  _context.Brands.ToList();
            
        }
    }
}
