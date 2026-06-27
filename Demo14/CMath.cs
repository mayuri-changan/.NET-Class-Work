namespace Demo14
{
    public class CMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Add={x + y}");


        }
        private void sub(int x, int y)
        {
            Console.WriteLine($"Sub={x - y}");
        }
        protected void mul(int x, int y)
        {
            Console.WriteLine($"mul={x * y}");

        }
        internal void Div(int x, int y)
        {
            Console.WriteLine($"Div={x / y}");
        }
        protected internal void Squ(int x)
        {
            Console.WriteLine($"Squ={x * x}");
        }
    }
    public class Demo
    {
        public void WrapperMethod()
        {
            CMath obj = new CMath();
            obj.Add(1, 2);
            obj.Div(12, 4);
            obj.Squ(5);
        }
    }
    public class MyClass : CMath
    {
        public void WrapperMethod()
        {
            mul(2, 4);
            Add(1, 2);
            Div(2, 4);
            Squ(2);

        }
    }

}



    
