using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
