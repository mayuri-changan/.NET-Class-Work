using Q7_RestAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Q7_RestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Mayuri",
                Department = "IT",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 40000
            }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound("Employee Not Found");

            return Ok(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            employees.Add(emp);
            return Ok("Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee emp)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee Not Found");

            employee.Name = emp.Name;
            employee.Department = emp.Department;
            employee.Salary = emp.Salary;

            return Ok("Employee Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee Not Found");

            employees.Remove(employee);

            return Ok("Employee Deleted Successfully");
        }
    }
}