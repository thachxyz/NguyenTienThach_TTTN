using BanSmartPhone.Models;
using DAO;
using DAO.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BanSmartPhone.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly TienThachContext _context;
        private readonly ISiteContext _siteContext;
    
        public CartController(ILogger<CartController> logger, TienThachContext context, ISiteContext siteContext)
        {
            _logger = logger;
            _context = context;
            _siteContext = siteContext;
        }
        public IActionResult Index()
        {


            if (_siteContext.CurrentUser == null) { 
                return RedirectToAction("Login","Auth");
            }

				var cart = _context.Carts.Where(c => c.UserId == _siteContext.CurrentUser.Id).Include(p => p.Product).ThenInclude(p => p.Images).ToList();
				return View(cart);
			
        }

        public IActionResult Add(Cart model)
        {

            var carts = new Cart();
            carts.Productid=model.Productid;
            carts.Quantity = model.Quantity;

            if (_siteContext.CurrentUser == null)
            {
                return RedirectToAction("Login","Auth");
            }



            carts.UserId= _siteContext.CurrentUser.Id;
            var product = _context.Products.FirstOrDefault(p => p.Id == model.Productid);
            carts.SubPrice = (double)(carts.Quantity * product.Price);
            _context.Carts.Add(carts);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        /* day la gio hang*/
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChecNkOut(CheckOutViewModel model)
        {
            var order = new Oder();

            order.Customer.FullName = model.FullName;
            order.Customer.Diachi = model.Address; 
            order.Customer.Phone = model.PhoneNumber;
           order.Customer.UserId= _siteContext.CurrentUser.Id;
            _context.Add(order);
            _context.SaveChanges();


            return RedirectToAction("Notify");
        }
        [HttpGet]
        public IActionResult Notify()
        {


            return View();
        }
    }
}
