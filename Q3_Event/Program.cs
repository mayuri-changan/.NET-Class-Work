using System;
using System.Security.Claims;
using Q3_ExceptionHandling;

namespace Q3_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            Person person = new Person();

            // Subscribe Event
            alarm.Ring += person.WakeUp;

            Console.WriteLine("Press Enter to Start Alarm...");
            Console.ReadLine();

            // Raise Event
            alarm.StartAlarm();
        }
    }
}