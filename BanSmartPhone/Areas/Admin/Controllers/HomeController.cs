using DAO;

using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("quan-tri")]
    public class HomeController : Controller
    {
        [Route("trang-chu")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
