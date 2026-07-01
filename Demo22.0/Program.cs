namespace Demo22._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------collections-----------------------");
            Emp emp1 = new Emp();
            emp1.Id = 1;
            emp1.Name = "Mayuri";


            Emp emp2 = new Emp();
            emp2.Id = 2;
            emp2.Name = "Neha";


            Emp emp3 = new Emp();
            emp3.Id = 3;
            emp3.Name = "John";
            Emp[] emps = new Emp[3];
            emps[0] = emp1;     
            emps[1] = emp2;
            emps[2] = emp3;
            for (int i = 0; i < emps.Length; i++)
            {

                emps[i].GetEmpDetails();
            }
                    
                
        }
        public class Emp
        {
            private int _Id;
            private string _Name;
            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }


            }
            public void GetEmpDetails()
            {
                Console.WriteLine($"Id:{Id},Name:{Name}");
            }
        }
    }
}

    
