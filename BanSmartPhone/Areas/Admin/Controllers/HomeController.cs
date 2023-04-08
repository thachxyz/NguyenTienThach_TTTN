using BanSmartPhone.Controllers;
using BanSmartPhone.Models;
using DAO;

using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("quan-tri")]
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly TienThachContext _context;
        private readonly ISiteContext _siteContext;

        public HomeController(ILogger<HomeController> logger, TienThachContext context, ISiteContext siteContext)
        {
            _logger = logger;
            _context = context;
            _siteContext = siteContext;
        }
       



        [Route("trang-chu")]
        public IActionResult Index()
        {
            
           



            return View();
        }
    }
}
