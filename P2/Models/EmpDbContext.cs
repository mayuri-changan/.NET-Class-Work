using Microsoft.AspNetCore.Mvc;


namespace P2.Models
{
    public class EmpDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
