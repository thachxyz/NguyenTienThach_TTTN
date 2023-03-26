using DAO.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Models
{
    public class HomeViewModel
    {
      public  List<Product> HotProducts { get; set; }


        public List<Category> Categories { get; set; }



    }
}
