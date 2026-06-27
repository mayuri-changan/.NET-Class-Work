
using Demo14;
namespace Demo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CMath cmath=new CMath();
            cmath.Add(10, 20);
            Test test =new Test();
            test.TestWrapperMethod();

        }
        public class Test : CMath 
        {
            public void TestWrapperMethod()
            {
                Add(4, 4);
                mul(4, 4);
                Squ(3);

            }
        
        }

    }
}
