using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Doors : {NumberOfDoors}");
        }
    }
}
