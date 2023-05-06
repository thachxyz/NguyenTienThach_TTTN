using BanSmartPhone.Models;
using DAO.Entity;
using DAO.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

namespace BanSmartPhone.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Route("quan-tri")]
	public class ProductController : Controller
    {
        ProductService _productService;
        BrandService _brandService;
        CategoriesService _categoriesService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductController(IWebHostEnvironment hostEnvironment) {
            _productService = new ProductService();
            _brandService = new BrandService();
            _categoriesService = new CategoriesService();
            _hostEnvironment = hostEnvironment;
        }


        [Route("quan-ly-san-pham")]
		public IActionResult Index(string query, string cat, string sort, int page=1, int pageSize = 3)
        {
            ProductViewModel model = new ProductViewModel();
            model.Products = _productService.getPage(pageSize, page);
            model.Page = page;
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(long id)
        {
            _productService.delete(id);
            return RedirectToAction("Index");
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
        [HttpGet]
        [Route("tao-sanpham")]
        public IActionResult Create()
        {
            ProductCreateViewModel model = new ProductCreateViewModel();

            GetSelectList(model);
            return View(model);
        }
        [HttpPost]
        [Route("tao-sanpham")]
        public IActionResult Create(ProductCreateViewModel model)
        {
            Product product = new Product();
            product.BrandId = model.BrandId;
            product.CategoryId = model.CategoryId;  
            product.Price = model.Price;
            product.NameProduct = model.NameProduct;
            product.SalePrice = model.SalePrice;
            product.Alias = Uri.EscapeDataString(model.Alias);

            Image image = new Image();
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            image.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Image/", fileName);
            image.Image1 = Path.Combine("/Image/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                 model.ImageFile.CopyToAsync(fileStream);
            }
            //Insert record
            product.Images.Add(image);
            _productService.save(product);
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
