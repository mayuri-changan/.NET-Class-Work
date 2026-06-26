using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.WrapperMethod();

            HR hr = new HR();
            hr.Display();
        }
    }

    public class Person
    {
        public virtual string Name { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Person : Display");
        }
    }
    public class Employee : Person
    {
        public sealed override string Name { get => base.Name; set => base.Name = value; }
        public sealed override void Display()
        {
            Console.WriteLine("Employee: Display");
        }
    }
    public sealed class HR : Employee
    {
        //public override string Name { get => base.Name; set => base.Name = value; }
        //public override void Display()
        //{
        //    Console.WriteLine("HR: Display");

        //}
        public void EmpData()
        {
           
            Console.WriteLine("EmpData: HR");
        }
    }
    public class Demo 
    {
        public void WrapperMethod()
        {
            HR obj = new HR();
            obj.EmpData();
        }
    }

}

