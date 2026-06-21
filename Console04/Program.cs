namespace Console04
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int x = 10;
            int y = 20;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Addition is");
            Console.WriteLine(x+" "+x.GetType().ToString()+ "\n"+y + " " + y.GetType().ToString());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Subtraction is");
            Console.WriteLine(x-y);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("String is:");
            String s = "Mayuri Changan";
            Console.WriteLine(s+" "+s.GetType().ToString());
            Console.WriteLine("---------------------------------------");
            short z = 50;      
            Console.WriteLine(z+" "+z.GetType().ToString());
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            long g = 123456777;
            Console.WriteLine(g+" "+g.GetType().ToString());
            Console.WriteLine("---------------------------------------");
            double d = 555555.67;
            Console.WriteLine(d +" " + d.GetType().ToString());
            Console.WriteLine("---------------------------------------");
            Boolean IsActive = true;
            Console.WriteLine(IsActive + " " + IsActive.GetType().ToString());
            Console.WriteLine("---------------------------------------");


        }
    }
}
