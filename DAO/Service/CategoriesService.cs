using DAO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Service
{
    public class CategoriesService
    {
        private readonly TienThachContext _context;

        public CategoriesService()
        {
            _context = new TienThachContext();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();

        }
    }
}
