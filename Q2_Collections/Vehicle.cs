using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Speed : {Speed}");
        }
    }
}