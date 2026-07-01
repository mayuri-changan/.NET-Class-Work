namespace Demo22._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("=============================================ARRAY===================================================");
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }
            Console.WriteLine("=============================================DAYS===================================================");
            string[] days = new string[5];
            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i].ToString());
            }

            Console.WriteLine("=============================================OBJ===================================================");
            Object[] arr = new Object[5];
            arr[0] = 1000;
            arr[1] = "MayuriChangan";
            arr[2] = 123.456;
            arr[3] = "somethingSomething";


            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                object obj = arr[i];
                if (obj is int)
                {
                    int j = Convert.ToInt32(obj);
                    Console.WriteLine(j.ToString());
                }
                if (obj is string)
                {
                    string str = obj as string;
                    Console.WriteLine(str);
                }

                if (obj is double)
                {
                    double d = Convert.ToDouble(obj);
                    Console.WriteLine(d.ToString());
                }



            }


            Console.WriteLine("----------------------------------------------------------------------------------------------------");


        }
    }
}
    

