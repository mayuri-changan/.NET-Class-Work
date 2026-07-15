
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {// Car Object
            Car car = new Car();

            Console.Write("Enter Car Brand: ");
            car.Brand = Console.ReadLine();

            Console.Write("Enter Car Speed: ");
            car.Speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Doors: ");
            car.NumberOfDoors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n----- Car Details -----");
            car.ShowDetails();
            Console.WriteLine("Doors : " + car.NumberOfDoors);
            car.Start();
            car.Drive();
            car.Stop();

            Console.WriteLine();

            // Bike Object
            Bike bike = new Bike();

            Console.Write("Enter Bike Brand: ");
            bike.Brand = Console.ReadLine();

            Console.Write("Enter Bike Speed: ");
            bike.Speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Has Helmet (true/false): ");
            bike.HasHelmet = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n----- Bike Details -----");
            bike.ShowDetails();
            Console.WriteLine("Helmet : " + bike.HasHelmet);
            bike.Start();
            bike.Ride();
            bike.Stop();
        }
    }
}