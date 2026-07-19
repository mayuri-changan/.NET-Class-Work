namespace Q4_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=101, Name="Mayuri", Department="IT", Salary=50000},
            new Employee{Id=102, Name="Rahul", Department="HR", Salary=35000},
            new Employee{Id=103, Name="Amit", Department="IT", Salary=60000},
            new Employee{Id=104, Name="Sneha", Department="Sales", Salary=45000},
            new Employee{Id=105, Name="Pooja", Department="IT", Salary=70000}
        };

            // 1. Display All Employees
            Console.WriteLine("All Employees");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Salary}");
            }

            // 2. Employees from IT Department
            Console.WriteLine("\nIT Department Employees");
            var itEmployees = employees.Where(e => e.Department == "IT");

            foreach (var emp in itEmployees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department}");
            }

            // 3. Salary greater than 50000
            Console.WriteLine("\nSalary > 50000");

            var highSalary = employees.Where(e => e.Salary > 50000);

            foreach (var emp in highSalary)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }

            // 4. Sort by Salary
            Console.WriteLine("\nSorted by Salary");

            var sorted = employees.OrderBy(e => e.Salary);

            foreach (var emp in sorted)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }

            // 5. Highest Salary
            Console.WriteLine("\nHighest Salary = " + employees.Max(e => e.Salary));

            // 6. Lowest Salary
            Console.WriteLine("Lowest Salary = " + employees.Min(e => e.Salary));

            // 7. Total Employees
            Console.WriteLine("Total Employees = " + employees.Count());

            // 8. First Employee
            var first = employees.FirstOrDefault();

            Console.WriteLine("\nFirst Employee");
            Console.WriteLine(first.Name);

            // 9. Find Employee by Id
            var emp101 = employees.FirstOrDefault(e => e.Id == 101);

            Console.WriteLine("\nEmployee with ID 101");
            Console.WriteLine(emp101.Name);
        }
    }
}