using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_ExceptionHandling
{
    public class Alarm
    {
        // Delegate
        public delegate void AlarmHandler();

        // Event
        public event AlarmHandler Ring;

        // Raise Event
        public void StartAlarm()
        {
            Console.WriteLine("Alarm Started...");

            if (Ring != null)
            {
                Ring();
            }
        }
    }
}