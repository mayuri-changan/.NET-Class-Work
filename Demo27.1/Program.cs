namespace Demo27._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================EXCEPTION HANDLING======================================================\n");
            int x = 100;
            int y = 0;
            try
            {
                //if (y == 0)
                //{
                //    throw new MyCustomException("Divisor can not be zero");
                //}
                int div = x / y;
                Console.WriteLine($"Div result:{div}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
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
            public MyCustomException(string message) : base(message)
            {
            }

        }




    }
}
