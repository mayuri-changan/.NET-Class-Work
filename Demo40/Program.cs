using System.Reflection.Metadata.Ecma335;
namespace Demo40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            IEnumerable<Emp> emps = new List<Emp>() {

                new Emp(){ Id=1,Name="Mayuri",Address="sangavi"},
                new Emp(){Id=2,Name="Priya",Address="kalewadi"},
                new Emp(){Id=2,Name="Tushar",Address="natepute"},
                new Emp(){Id=2,Name="Boyd",Address="pune"},
                new Emp(){Id=2,Name="Swapnil",Address="sangavi"}

            };
            #region

            var result = emps.MyWhere(e => e.Address.Contains("k"));
            foreach (var emp in result)
            {
                emp.DisplayEmpData();
            }
            #endregion

            #region emps.MyWhere().MySelect()
            //var result = emps.MyWhere(e => e.Address.Contains("p")).MySelect();

            //foreach (var emp in result)
            //{
            //    emp.DisplayEmpData();
            //}
            #endregion

            Func<Emp, bool> func = e => e.Address.StartsWith("p");

            var result2 = emps.Where(e => e.Address.StartsWith("p"))
                            .Select(e => e)
                            .ToList();

            foreach (var emp in result)
            {
                emp.DisplayEmpData();
            }

            #region int[] , Where, Select, ToList()
            // int[] numbers = { 1,2,3,4,5,6,7,8,9,10};

            //IEnumerable<int> evenNumbers = numbers.Where(no => no % 2 == 0);

            //IEnumerable<int> doubleNumbers= evenNumbers.Select(no => no*2);

            // List<int> lstnos = doubleNumbers.ToList();

            // List<int> lstnos2 =numbers.Where(no => no >7).Select(no => no*2).ToList();

            // foreach (int no in lstnos2)
            // {
            //     Console.WriteLine(no);
            // } 
            #endregion

        }
    }
    public static class MyClass
    {
        public static IEnumerable<Emp> MyWhere(this IEnumerable<Emp> allemps, Func<Emp, bool> predicate)
        {
            List<Emp> FilteredEmps = new List<Emp>();
            foreach (var emp in allemps)
            {
                if (predicate(emp))
                {
                    FilteredEmps.Add(emp);
                }
            }
            return FilteredEmps;
        }

        public static List<Emp> MySelect(this IEnumerable<Emp> allemps)
        {
            List<Emp> emps = new List<Emp>();
            foreach (var emp in allemps)
            {
                emps.Add(emp);
            }
            return emps;
        }
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

