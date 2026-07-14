using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using P1.Models;

namespace P1.Controllers
{
    [EnableCors(PolicyName ="IET")]
    [Route("api/[Controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmpDbContext _dbcontext;
        public ValuesController(EmpDbContext Context) { 
            _dbcontext=Context;
        
         
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
