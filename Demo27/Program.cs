namespace Demo27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("=======================================EXCEPTION HANDLING======================================================\n");
            int x = 100;
            int y = 2;
            try
            {
                int div = x / y;
                Console.WriteLine($"Div result:{div}");

            }
            catch( Exception ex ) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Every time finally block gets called !!!!!");
            }
        }
        public class MyCustomException : Exception 
        { 
            public MyCustomException(string message): base(message)
            {
            }
        
        }




    }
}
