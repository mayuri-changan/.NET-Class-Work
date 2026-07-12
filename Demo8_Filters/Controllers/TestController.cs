using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Microsoft.AspNetCore.Mvc;

namespace Demo8_Filters.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                int x = 100;
                var result = x / id;
                return new ContentResult() { Content = result.ToString(), ContentType = "text/plain" };
            }
            else
            {
                return new ContentResult() { Content = "Hi!", ContentType = "text/plain" };
            }
        }
    }
}
