using Microsoft.AspNetCore.Mvc;

namespace Demo04_AttributeBasedOnRouting.Controllers
{
    [Route("{controller}")]
    public class EmpController : Controller
    {
        [Route("{action}")] // "/Emp/Index"
        public IActionResult Index()
        {
            return View();
        }
        [Route("{action}/{unm?}/{pwd?}")]// "/Emp/About/unm/pwd"
        public IActionResult About(string? unm, string? pwd)
        {
            return View();
        }
    }
}

