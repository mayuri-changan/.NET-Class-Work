using Microsoft.AspNetCore.Mvc;

namespace Demo8_Filters.Controllers
{
    public class ExceptionController : Controller
    
        {
            public IActionResult Error()
            {
                return View();
            }
        }
    }
