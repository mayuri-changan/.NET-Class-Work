using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P1.Models;

namespace P1.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _context;

        public HomeController(EmpDbContext context)
        {
            _context = context;
        }

        // 1. GET ALL EMPLOYEES
        public IActionResult Index()
        {
            var result = _context.Emps.ToList();
            return View(result); // FIXED: Passing data to the view
        }

        // 2. CREATE (SHOW BLANK FORM)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // 3. CREATE (SAVE DATA SUBMITTED BY FORM)
        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                _context.Emps.Add(emp);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // FIXED: Clean redirect
            }
            return View(emp); // Returns form with errors if data is invalid
        }

        // 4. EDIT (SHOW FORM PRE-FILLED WITH CURRENT DATA)
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var empToBeEdited = _context.Emps.Find(id);
            if (empToBeEdited == null) return NotFound();

            return View(empToBeEdited);
        }

        // 5. EDIT (SAVE CHANGES)
        [HttpPost]
        public IActionResult Edit(int? id, Emp emp)
        {
            if (id == null) return NotFound();

            if (ModelState.IsValid)
            {
                var empToBeEdited = _context.Emps.Find(id);
                if (empToBeEdited == null) return NotFound();

                empToBeEdited.Name = emp.Name;
                empToBeEdited.Address = emp.Address;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

        // 6. VIEW DETAILS OF ONE EMPLOYEE
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var result = _context.Emps.Find(id);
            if (result == null) return NotFound();

            return View(result); // FIXED: Passing found employee
        }

        // 7. DELETE AN EMPLOYEE
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var result = _context.Emps.Find(id);
            if (result == null) return NotFound();

            _context.Emps.Remove(result); // FIXED: Removing the retrieved employee
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}