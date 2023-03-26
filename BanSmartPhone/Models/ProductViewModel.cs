using DAO.Entity;

namespace BanSmartPhone.Models
{
    public class ProductViewModel
    {
      public List<Product> Products { get; set; }
    
      public string Cat { get; set; }
      public string Sort { get; set; }
    }
}
