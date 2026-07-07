
using System.Collections;
using System.Threading.Channels;
namespace Demo39
    {
        internal class Program
        {
        static void Main(string[] args)
        {
            #region iterator
            //Console.WriteLine("Hello, World!");

            //    CustomCollection myCollectionObj = new CustomCollection();

            //    myCollectionObj.Add("Mon");
            //    myCollectionObj.Add("Tue");
            //    myCollectionObj.Add("Wed");
            //    myCollectionObj.Add("Thu");
            //    myCollectionObj.Add("Fri");
            //    myCollectionObj.Add("Sat");
            //    myCollectionObj.Add("Sun");

            //foreach (string day in myCollectionObj)
            //    {
            //        Console.WriteLine(day);
            //    }
            #endregion

            #region
            //    Demo demo=new Demo();
            //    Action action = new Action(demo.show);
            //    Action action1 = delegate ()
            //    {
            //        Console.WriteLine("Annonymous method");
            //    };
            //    Action action2 = () => Console.WriteLine("lambda Expression");
            //    action2();
            //}
            #endregion
            #region
            //int num = 2;
            //Func<int> doubleFuc = () => num * 2;
            //Func<string, string> func2 = (name) => $"Hello,{name}";
            //Console.WriteLine("enter your name");
            //string nm = Console.ReadLine();
            //Console.WriteLine(func2(nm));
            #endregion

            List<Emp> list = new List<Emp>() {
                new Emp(){ Id=1,Name="Mayuri",Address="sangavi"},
                new Emp(){Id=2,Name="Priya",Address="kalewadi"},
                new Emp(){Id=2,Name="Tushar",Address="natepute"},
                new Emp(){Id=2,Name="Boyd",Address="pune"},
                new Emp(){Id=2,Name="Swapnil",Address="sangavi"}

            };
            Console.WriteLine("Enter city initials:");
            string letter = Console.ReadLine()?.ToLower() ?? "";

            Predicate<Emp> predicate =
                e => e.Address.ToLower().Contains(letter);

            Predicate<Emp> predicate2 =
                e => e.Address.ToLower().StartsWith(letter);

            var filedata = list.FilteredEmpData(predicate2);

            foreach (var emp in filedata)
            {
                emp.DisplayEmpData();
            }

        }
    }
    public class CustomCollection : IEnumerable
            {
                private List<string> days = new List<string>();

                public List<string> Days
                {
                    get
                    {
                        return this.days;
                    }
                }

                public void Add(string day)
                {
                    days.Add(day);
                }

                public IEnumerator GetEnumerator()
                {
                    for (int i = 0; i < days.Count; i++)
                    {
                        yield return days[i];
                    }
            }
        }

        public class Demo
        {
        public void show()
            {
                Console.WriteLine("show method from Demo");

            }
        }

        public class Emp
        {
            public int Id
            {
                get; set;
            }
            public string Name
            {
                get; set;
            }
            public string Address
            { get; set; }
            public void DisplayEmpData()
            {
                Console.WriteLine($"Id:{Id},Name:{Name},Address:{Address}");
            }
        }
        public static class MyClass
        {
            public static List<Emp> FilteredEmpData(
                   this List<Emp> emps,
                   Predicate<Emp> predicate)
            {
                List<Emp> filteredEmps = new List<Emp>();

                foreach (Emp emp in emps)
                {
                    if (predicate(emp))
                    {
                        filteredEmps.Add(emp);
                    }
                }

                return filteredEmps;
            }
        }


    }
