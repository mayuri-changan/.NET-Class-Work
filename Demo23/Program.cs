namespace Demo23
{
    public delegate void MyDelegate<T>(T para);
    public delegate bool MyPredicateDel<T1, T2>(T1 p1, T2 p2);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClass obj=new MyClass();
            
            MyDelegate<string> del = new MyDelegate<string>(obj.Show);

            del("Hello!!!!! Mayuri How are you ?\n");
        }

        public class Demo
        {


        }
        public class MyClass
        { 
            public void Show<T>(T obj)
            {
                Console.WriteLine($"{obj}type:{obj.GetType().ToString()}");


            }
            public void Display(double salary)
            {
                Console.WriteLine($"{salary}");
            }
        }

    }
}
