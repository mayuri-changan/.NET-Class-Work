using Microsoft.AspNetCore.Mvc;

namespace Practice_1.Models
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
