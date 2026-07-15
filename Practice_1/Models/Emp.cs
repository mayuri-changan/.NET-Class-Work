using Microsoft.AspNetCore.Mvc;

namespace Practice_1.Models
{
    public class Emp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
