using Demo8_Filters.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

namespace Demo8_Filters.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(User user)// ModelBinder
        {
            if (user.UserName == "admin" && user.Password == "1234")
            {
                ControllerContext.HttpContext.Session.SetString("isLoggedIn", "true");
                ControllerContext.HttpContext.Session.SetString("UserName", user.UserName);
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Credentials are invalid";
                return View();
            }
        }
    }
}
