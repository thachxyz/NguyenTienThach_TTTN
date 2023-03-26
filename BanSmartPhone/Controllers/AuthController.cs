using BanSmartPhone.Models;
using DAO.Entity;
using DAO.Service;
using Microsoft.AspNetCore.Mvc;
namespace BanSmartPhone.Controllers
{
	public class AuthController : Controller 
	{

		[HttpGet]
		public IActionResult Login()
		{ 
		return View();
		}
        [HttpPost]
		public IActionResult Login(LoginModel model)
		{
			var dao = new UserService();
			var user = dao.getByUserName(model.UserName);
			if(user== null)
			{
				return View("Error");
			}
			
			if(user.Pass!.Equals(model.Password))
			{
				user = dao.getByUserName(model.UserName);
				HttpContext.Session.SetString("username", user.UserName);
				HttpContext.Session.SetInt32("id", (int)user.Id);
				return RedirectToAction("Index","Home");
			}
			else
			{
				ViewData["Error"] = "";

                return View();
            }

			return View();
		}
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
		[HttpPost]
		public IActionResult Register(RegisterModel model)
		{
		
            var dao = new UserService();
			if (!model.Password.Equals(model.ConFirmPassword))
			{
                ViewData["Error"] = "Mật khẩu không khớp hoặc tài khoản đã toàn tại";


                return View(model);

            }
				User user = new User();
				user.FullName = model.FullName;
				user.UserName = model.Username;
				user.Pass = model.Password;
                dao.save(user);
                return RedirectToAction("Login", "Auth");
            
			return View();

        }
    }
}
