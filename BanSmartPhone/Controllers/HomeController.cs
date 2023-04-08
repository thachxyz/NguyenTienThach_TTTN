
using BanSmartPhone.Models;
using DAO;
using DAO.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Drawing.Printing;
using X.PagedList;

namespace BanSmartPhone.Controllers
{
	
	[Route("")]
	public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TienThachContext _context;
        public HomeController(ILogger<HomeController> logger, TienThachContext context)
        {
            _logger = logger;
            _context = context;
        }

		[Route("")]
		public IActionResult Index(int? page, int pageSize = 4)
        {
			
			HomeViewModel home = new HomeViewModel();

            home.HotProducts = _context.Products.Include(image => image.Images).ToPagedList(page ?? 1, pageSize);
            home.Categories = _context.Categories.ToList();

            

            return View(home);
        }

        
		//public IActionResult Privacy()
  //      {
  //          return View();
  //      }

  //      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


  //      public IActionResult Error()
  //      {
  //          return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  //      }
        








    
     

       
           
          
        












    }
}