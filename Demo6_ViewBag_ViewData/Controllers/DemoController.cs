using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;

namespace Demo6_ViewBag_ViewData.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // dynamic
            // ViewBag dynamic type -- Key : Value based collection which is available between same action method and its view
            // ViewBag internally uses ViewData Collection
            // means e.g : ViewBag.fullname == ViewData["fullname"]
            ViewBag.Title = "Index";
            ViewBag.Number = 123456;

            // ViewData Object type -- Key : Value based collection which is available between same action method and its view
            ViewData["fullname"] = "Boyd king";

            string[] names = new string[] { "Shinchan", "Doremon", "Oggy" };

            ViewBag.Names = names;

            int[] numbers = { 1, 2, 3, 4, 5 };

            ViewData["Numbers"] = numbers;

            TempData["Dev_Name"] = "Mayuri";

            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
