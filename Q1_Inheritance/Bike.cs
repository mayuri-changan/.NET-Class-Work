using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Bike : Vehicle
    {

        public bool HasHelmet;

        public void Ride()
        {
            Console.WriteLine("Bike is Riding");
        }
    }
}