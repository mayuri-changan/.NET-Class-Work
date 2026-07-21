using Q8_ReactFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Q8_ReactFrontEnd.Controllers
{
    public class EmployeeController : Controller
    {
        HttpClient client;

        public EmployeeController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7198/"); // Change to your API port
        }

        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync("api/Employee");

            List<Employee> employees = new List<Employee>();

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

                employees = JsonSerializer.Deserialize<List<Employee>>
                (
                    data,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                ) ?? new List<Employee>();
            }

            return View(employees);
        }
    }
}