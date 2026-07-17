namespace Q3_CustomException
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new Exception("You are not eligible to vote.");
                }

                Console.WriteLine("You are eligible to vote.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
