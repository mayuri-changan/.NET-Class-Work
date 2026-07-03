using System.ComponentModel;
using System.Globalization;
using System.Drawing;

namespace Demo25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n...................................................... GENERIC COLLECTION............................................................\n");
            Console.WriteLine("================================================LIST====================================================\n");
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            for (int i = 0; i < numbers.Count; i++)
            {
                
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("==========================================STACK=======================================================\n");
            Stack<string> st = new Stack<string>();
            st.Push("1");
            st.Push("2");
            st.Push("3");
            st.Push("4");
            st.Push("5");
            st.Push("6");
            int count = st.Count;
            for(int i = 0;i < count;i++)
            {
                Console.WriteLine(st.Pop());
            }

            Console.WriteLine("==========================================EMP LIST=======================================================\n");


            Emp emp1 = new Emp();
            emp1.Id = 1;
            emp1.Name = "Mayuri";
            emp1.Address = "Pune";

            Emp emp2 = new Emp();
            emp2.Id = 2;
            emp2.Name = "swapnil";
            emp2.Address = "Aundh";


            Emp emp3 = new Emp();
            emp3.Id = 3;
            emp3.Name = "priya";
            emp3.Address = "Wakad";

            List<Emp>allemps=new List<Emp>();
            allemps.Add(emp1);
            allemps.Add(emp2);
            allemps.Add(emp3);

            for(int i = 0; i < allemps.Count;i++)
            {
                Console.WriteLine($"Id:{allemps[i].Id},Name:{allemps[i].Name},Address:{allemps[i].Address}");
            }
            Console.WriteLine("==========================================DICTIONARY=======================================================\n");
            Dictionary<int,Emp>allEmps=new Dictionary<int,Emp>();
            allEmps.Add(1, emp1);
            allEmps.Add(2, emp2);
            allEmps.Add(3, emp3);
            foreach(Emp emp in allEmps.Values)
            {
                Console.WriteLine($"Id:{emp.Id},Name:{emp.Name},Address:{emp.Address}");
                
            }
            Console.WriteLine("==========================================KEY VALUE PAIR=======================================================\n");

            foreach (int key in allEmps.Keys)
            {
                Console.WriteLine($"Key:{key},Value:{allEmps[key].Name}");
            }

            Console.WriteLine("........................................................................................................................\n");











        }

    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }
            public string Name
        {
            get
            {
                return _EName;
            }
            set
            {
                _EName = value;
            }
        }
        public int Id
        {
            get { return _EId; }
            set
            {
                _EId = value;
            }
        }

    }


}
