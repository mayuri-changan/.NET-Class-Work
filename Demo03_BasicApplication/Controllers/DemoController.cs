using Microsoft.AspNetCore.Mvc;

namespace Demo03_BasicApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Data(string unm, string pwd)
        {
            return $"User Name : {unm}, Password: {pwd}";
        }
        public string Dashboard(int? id, string? nm)
        {
            return $"Id: {id},name: {nm}";
        }
    }
}
//http://localhost:5199/Demo/Data?unm=Mayurii&pwd=123456
//http://localhost:5199/Demo/Dashboard?id=1&nm=MayuriiChangan