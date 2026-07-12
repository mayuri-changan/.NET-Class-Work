using System.Collections;
using System.Diagnostics;
using Demo6_ViewBag_ViewData.IETDbViewModels;
using Demo6_ViewBag_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo6_ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> emps = new List<Emp>()
            {
                new Emp(){ Id= 1, Name ="mayuri", Address="Solapur"},
                 new Emp(){ Id= 2, Name ="Prachi", Address="Nagar"},
                new Emp(){ Id= 3, Name ="kalpana", Address="Jalgaon"},
                new Emp(){ Id= 4, Name ="Komal", Address="Pune"},
                new Emp(){ Id= 5, Name ="Boyd", Address="Mumbai"},
            };

        List<Customer> custs = new List<Customer>() {
            new Customer(){ CId = 11, CName = "Shinchan"},
            new Customer(){ CId = 12, CName = "Doremon"},
            new Customer(){ CId = 13, CName = "Oggy"}
        };

        // One action method = one view 
        public IActionResult Index()
        {
            //string fullname = "Hugh Jackman";
            //return View("Index", fullname);

            // @Model is Razor Syntax(partial C# + partial html)
            // Model property(available in index.cshtml page) resolves what Entity type you are passing from action method to View
            // via View() method
            int id = 1234;
            return View(id);

        }

        public IActionResult GetEmpData()
        {
            //@Model : IEnumerable<Emp>
            return View(emps);
        }
        public IActionResult GetData()
        {
            //@Model : ViewModel = IEnumerable<Emp>+IEnumerable<Customer>
            IETDbViewModel viewmodelObj = new IETDbViewModel() { allEmployees = emps, allCustomers = custs };

            return View(viewmodelObj);
        }
        public IActionResult GetData1()
        {
            //@Model : IEnumerable<Emp>
            //@Model : IEnumerable<Customer>
            //@Model : System.Collections.ArrayList
            ArrayList arrlst = new ArrayList() { emps, custs };
            return View("GetData1", arrlst);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

