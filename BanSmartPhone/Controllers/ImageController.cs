using Microsoft.AspNetCore.Mvc;

namespace BanSmartPhone.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
