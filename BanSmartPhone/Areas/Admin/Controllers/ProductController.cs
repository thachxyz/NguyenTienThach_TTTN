using BanSmartPhone.Models;
using DAO.Entity;
using DAO.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BanSmartPhone.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Route("quan-tri")]
	public class ProductController : Controller
    {
        ProductService _productService;
        BrandService _brandService;
        CategoriesService _categoriesService;
        public ProductController() {
            _productService = new ProductService();
            _brandService = new BrandService();
            _categoriesService = new CategoriesService();
        }


        [Route("quan-ly-san-pham")]
		public IActionResult Index(string query, string cat, string sort, int page=1, int pageSize = 3)
        {
            ProductViewModel model = new ProductViewModel();
            model.Products = _productService.getPage(pageSize, page);
            model.Page = page;
            return View(model);
        }

		[Route("tao-sanpham/{id}")]
		[HttpGet]
        public IActionResult Edit(long id)
        {
            var entity = _productService.get(id);
            ProductCreateViewModel model = new ProductCreateViewModel {
                BrandId = entity.BrandId,
                Id = entity.Id,
                CategoryId = entity.CategoryId,
                Alias = entity.Alias,
                SalePrice = entity.SalePrice,
                Price = entity.Price,
                Detail = entity.Detail,
                NameProduct = entity.NameProduct,
                Images = entity.Images.ToList()
                
            };

            GetSelectList(model);
            return View(model);
        }

        [HttpPost]
        [Route("tao-sanpham/{id}")]
        public IActionResult Edit(long id, ProductCreateViewModel model)
        {
            Product product = new Product();
            product.Id = id;
            product.BrandId = model.BrandId;
            product.Price = model.Price;
            product.NameProduct = model.NameProduct;
            product.SalePrice = model.SalePrice;
           _productService.update(product);
            return RedirectToAction("Index");
        }
        [NonAction]
        public void GetSelectList(ProductCreateViewModel model)
        {
            model.BrandsList = _brandService.GetAll().Select(x=>new SelectListItem { Text= x.BrandName, Value=x.Id.ToString()}).ToList();
            model.CategoriesList = _categoriesService.GetAll().Select(x => new SelectListItem { Text = x.CatName, Value = x.Id.ToString() }).ToList(); ;

        }

    }
}
