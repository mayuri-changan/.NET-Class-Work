using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    public class Employee
    {
        public string Department;
         
        public Employee()
        {

        }
        public Employee(string department)
        {
            Department = department;

        }

    }
    public class Developers : Employee
    {
        public string Projects;
        public Developers() : base()
        {
        }
        public Developers(string projectName, string dpt) : base(dpt)
        {
            Projects = projectName;
        }


    }
}

