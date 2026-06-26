using System.Security.Cryptography.X509Certificates;

namespace Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.EId = 100;
            Console.WriteLine(emp.EId);

            emp.EName = "MayuriChangan";
            Console.WriteLine(emp.EName);

            
            string[] days = new string[3];
            days[0] = "Friday";
            days[1] = "Monday";
            days[2] = "Sunday";

            emp.WeekDays = days;
            for (int i = 0; i < emp.WeekDays.Length; i++)
            {
                Console.WriteLine(emp.WeekDays[i]);
            }


            
        }
    }
    public class Employee
    {
        private int _EId;
        private string _EName;
        
        private string[] _Days;

        

        public string[] WeekDays
        {
            set 
            { _Days = value; }
            get
            { return _Days; }
        }
        
        public int EId
        {
            set
            {
                if (value == 100)
                    _EId = value;
                else
                    _EId = 0;
            }
            get
            {
                if (_EId == 100)
                    return _EId + 10;
                else
                    return _EId * 0;
            }
        }

        public string EName
        {
            set { _EName = value; }
            get
            {
                
                return $"Mr/Mrs. {_EName}";
            }
        }

       

        

        

        


    }

    
    
}
