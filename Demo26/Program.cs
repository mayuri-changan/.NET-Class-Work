//using statement:namespace resolve
using System;

namespace Demo26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......................................GARBAGE COLLECTOR.............................................\n");
            MyClass obj=new MyClass();
            MyClass obj2= new MyClass();
            
            obj.Dispose();
            obj2.Show();
        }
        public class MyClass: IDisposable
        {
            public void Dispose()
            {
                
                Console.WriteLine("Disposal method gets called!!!!!!");
                GC.SuppressFinalize(this);
            }
            public void Show()
            {
                Console.WriteLine("show method in garbage collector");
            }

        }
    }
}
