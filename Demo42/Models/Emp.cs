using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo42.Models
{
    public class Emp 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetEmpData()
        {
            Console.WriteLine($"Id: {Id},Name: {Name}, Address: {Address}");
        }
    }
}