using Q1;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Console.Write("Enter number of Cars: ");
            int carCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                Car car = new Car();

                Console.WriteLine($"\nEnter Details of Car {i + 1}");

                Console.Write("Brand: ");
                car.Brand = Console.ReadLine();

                Console.Write("Speed: ");
                car.Speed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of Doors: ");
                car.NumberOfDoors = Convert.ToInt32(Console.ReadLine());

                cars.Add(car);
            }

            // Collection of Bikes
            List<Bike> bikes = new List<Bike>();

            Console.Write("\nEnter number of Bikes: ");
            int bikeCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < bikeCount; i++)
            {
                Bike bike = new Bike();

                Console.WriteLine($"\nEnter Details of Bike {i + 1}");

                Console.Write("Brand: ");
                bike.Brand = Console.ReadLine();

                Console.Write("Speed: ");
                bike.Speed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Has Helmet (true/false): ");
                bike.HasHelmet = Convert.ToBoolean(Console.ReadLine());

                bikes.Add(bike);
            }

            // Display Cars
            Console.WriteLine("\n===== CAR DETAILS =====");

            foreach (Car car in cars)
            {
                car.Display();
                Console.WriteLine("Doors : " + car.NumberOfDoors);
                Console.WriteLine("-----------------------");
            }

            // Display Bikes
            Console.WriteLine("\n===== BIKE DETAILS =====");

            foreach (Bike bike in bikes)
            {
                bike.Display();
                Console.WriteLine("Helmet : " + bike.HasHelmet);
                Console.WriteLine("-----------------------");
            }
        }
    }
}