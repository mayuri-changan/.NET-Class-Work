namespace Demo41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>() {
                new Emp(){Id = 1, Name="Mayuri",Address="sangavi" },
                new Emp(){Id = 2, Name="Swpanil",Address="sangavi" },
                new Emp(){Id = 3, Name="Riya",Address="pune" },
                new Emp(){Id = 4, Name="Priya",Address="pune" },
                new Emp(){Id = 5, Name="Tushar",Address="aundh" },
                new Emp(){Id = 6, Name="boyd",Address="kalewadi" }
            };

            
            #region select all emp
            //var result = (from emp in emps
            //             select emp);


            //foreach (var emp in result)
            //{
            //    emp.DisplayEmpData();
            //}
            #endregion

            #region emp.Name
            //var result = (from emp in emps
            //              select emp.Name);

            //var result1 = emps.Select(e=>e.Name);

            //foreach (var empName in result1)
            //{
            //    //emp.DisplayEmpData();
            //    Console.WriteLine(empName);
            //} 
            #endregion

            #region emps.Where().Select
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("p")
            //              select emp);

            ////var result1 = emps.Where(emp.Address.StartsWith("p")).Select(e => e);

            //foreach (var emp in result)
            //{
            //    emp.DisplayEmpData();
            //} 
            #endregion

            #region emps.Where().Select() -> Names
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("p")
            //              select emp.Name);

            ////var result1 = emps.Where(emp.Address.StartsWith("p")).Select(e => e.Name);

            //foreach (var empName in result)
            //{
            //    Console.WriteLine(empName);
            //} 
            #endregion

            #region LINQ with Holder class
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("p")
            //              select new Holder() { HName = emp.Name, HAddress = emp.Address});

            //foreach (Holder hObj  in result)
            //{
            //    Console.WriteLine($"Name: {hObj.HName}, Address: {hObj.HAddress}");
            //} 
            #endregion

            #region LINQ with Anonymous Types
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("p")
            //              select new { Nm = emp.Name, Add = emp.Address }).ToList();

            //foreach (var hObj in result)
            //{
            //    Console.WriteLine($"Name: {hObj.Nm}, Address: {hObj.Add}");
            //} 
            #endregion

            #region LINQ to int[] : sorting
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = (from no in numbers
            //              where no % 2 == 0 
            //              orderby no descending
            //              select no*2);

            //foreach (var no in result)
            //{
            //    Console.WriteLine(no);
            //} 
            #endregion

            #region select all emp
            //var result = (from emp in emps
            //             where emp.Address.StartsWith("p")
            //             select emp);

            var result = (from emp in emps
                          where emp.Address.StartsWith("a")
                          select emp).ToList();


            emps.Add(new Emp() { Id = 7, Name = "vijay", Address = "panji" });

            foreach (var emp in result)
            {
                emp.DisplayEmpData();
            }
            #endregion

        }
    }

    public class Holder
    {
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void DisplayEmpData()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Address: {Address}");
        }
    }
}
