using DAO.Entity;
using X.PagedList;

namespace BanSmartPhone.Models
{
    public class ProductViewModel
    {
      public IPagedList<Product> Products { get; set; }
    
      public string Cat { get; set; }
      public string Sort { get; set; }

        public string Query { get; set; }
        public int Page { get; set; }
        public int pageSize { get; set; }
    }
}
