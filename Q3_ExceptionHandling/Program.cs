namespace Q3_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers.");
            }
            finally
            {
                Console.WriteLine("Program Finished.");
            }
        }
    }
}