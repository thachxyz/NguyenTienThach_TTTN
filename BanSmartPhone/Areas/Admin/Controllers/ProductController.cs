using BanSmartPhone.Models;
using DAO.Service;
using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Areas.Admin.Controllers
{
	[Area("Admin")]
	
	public class ProductController : Controller
    {
        ProductService _productService;

        public ProductController() {
            _productService = new ProductService();
        }


        [Route("quan-ly-san-pham")]
		public IActionResult Index(string query, string cat, string sort, int page=1, int pageSize = 3)
        {
            ProductViewModel model = new ProductViewModel();
            model.Products = _productService.getPage(pageSize, page);
            model.Page = page;
            

            return View(model);
        }
    }
}
