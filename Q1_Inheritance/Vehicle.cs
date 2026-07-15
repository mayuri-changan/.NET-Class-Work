using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Vehicle
    {
        public string Brand;
        public int Speed;

        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand : " + Brand);
            Console.WriteLine("Speed : " + Speed);
        }
    }
}