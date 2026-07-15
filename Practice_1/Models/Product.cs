using Microsoft.AspNetCore.Mvc;

namespace Practice_1.Models
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
