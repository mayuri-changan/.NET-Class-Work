using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace Demo05.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult<int> GetNumber()
        {
            return 12345678;
        }
        public ViewResult M1()
        {
            return View("~/Views/Demo/About.cshtml");

        }
        public string GetSomething(string fnm, string lnm)
        {
            return $"Hello,{fnm}{lnm}";

        }
        public JsonResult GetData()
        {
            var data = new
            {
                id = 100,
                name = "mayuri Changan",
                City = "Pune"

            };
            return Json(data);
        }
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }
        public async Task<ViewResult> GetTResult()
        {
            await Task.Delay(1000);
            return View("~/Views/Demo/About.cshtml");
        }
        public FileResult DownloadPDF()
        {
            var filepath = @"C:\Users\mayur\Desktop\.NET\.NET_MVC_WebServer\Demo05\Data\intro.pdf";
            var byteArray=System.IO.File.ReadAllBytes(filepath);
            return File(byteArray,"application/pdf","intro.pdf");
        }
    }
}