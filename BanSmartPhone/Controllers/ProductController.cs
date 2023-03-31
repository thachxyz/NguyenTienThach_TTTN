
using BanSmartPhone.Models;
using DAO;
using DAO.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Hosting;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using BanSmartPhone.Contant;
using System.Linq;

namespace BanSmartPhone.Controllers
{
  
    

    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly TienThachContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        

        

        public ProductController(ILogger<ProductController> logger, TienThachContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        /*chitietsanpham*/
        public IActionResult Detail(string alias)
        {
           
            Product products = _context.Products.Where(p=>p.Alias.Equals(alias)).Include(p=>p.Images).Include(p=>p.Brand).Include(p => p.Category).FirstOrDefault();
            return View(products);
        }
        /*Endchitietsanpham*/


        public IActionResult Index(string query, string cat, string sort)
        {

            ProductViewModel productViewModel= new ProductViewModel();

            var quer = _context.Products.Where(p => true);
            if (!string.IsNullOrEmpty(query))
            {
                quer = quer.Where(products => products.NameProduct.Contains(query));
            }
            if (!string.IsNullOrEmpty(cat))
            {
                quer = quer.Where(products => products.Category!.Alias!.Contains(cat));
            }
            if(!string.IsNullOrEmpty(sort))
            {
                if (sort.Equals(Contants.PRICE_SORT_DESC))
                {
                    quer = quer.OrderByDescending(p => p.Price);
                }
                if (sort.Equals(Contants.PRICE_SORT_ASC))
                {
                    quer = quer.OrderBy(p=>p.Price);
                }

            }
            List<Product> products=  quer.Include(image => image.Images).ToList();
            productViewModel.Products = products;
            productViewModel.Sort = sort;
            productViewModel.Cat = cat;

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));

            return View(productViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProductCreateViewModel model = new ProductCreateViewModel();
            return View(model);
        }
            [HttpPost]
        public async Task<IActionResult> Create(ProductCreateViewModel model)
        {
            Product product= new Product();
            product.NameProduct = model.NameProduct;
            product.Price = model.Price;
            product.SalePrice= model.SalePrice;
            product.Alias = model.Alias;
            product.CategoryId = model.CategoryId;
            product.BrandId= model.BrandId;
            product.CreatedAt=DateTime.Now;
            product.UpdatedAt=DateTime.Now;
            product.Detail= model.Detail;
            product.Alias= Uri.EscapeDataString(model.Alias);


            Image image = new Image();
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            image.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Image/", fileName);
            image.Image1 = Path.Combine("/Image/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await model.ImageFile.CopyToAsync(fileStream);
            }
            //Insert record
            product.Images.Add(image);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return View(model);
        }
        
    }
}
