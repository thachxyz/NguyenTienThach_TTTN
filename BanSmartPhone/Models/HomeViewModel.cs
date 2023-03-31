using DAO.Entity;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BanSmartPhone.Models
{
    public class HomeViewModel
    {
      public  IPagedList<Product> HotProducts { get; set; }

        
        public List<Category> Categories { get; set; }

        public string Query { get; set; }
        public string Cat { get; set; }
        public string Sort { get; set; }

        public int Page { get; set; }
        public int pageSize { get; set; }
    }
}
