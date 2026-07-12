using Demo7_LayoutPages.Models;
using Microsoft.AspNetCore.Mvc;


namespace Demo7_LayoutPages.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
        public IActionResult EmpData()
        {
            List<Emp> emps = new List<Emp>() {
                new Emp(){ Id  = 1, Name="Doremon",Address="Japan"},
                 new Emp(){ Id  = 2, Name="Shinchan",Address="China"},
                  new Emp(){ Id  = 3, Name="Nobita",Address="Japan2"}
            };
            return View(emps);
        }
    }
}
