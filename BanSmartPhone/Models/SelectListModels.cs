using Microsoft.AspNetCore.Mvc.Rendering;

namespace BanSmartPhone.Models
{
    public class SelectListModels
    {
      public  List<SelectListItem> CategoriesList { get; set; }   
      public   List<SelectListItem> BrandsList { get; set; }
    }
}
