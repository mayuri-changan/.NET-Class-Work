using static Demo20.Program.Subscriber;

namespace Demo20
{
    public delegate void MyHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------observer design pattern-------");
            Publisher publisher=new Publisher();
            Subscriber subscriberA = new Subscriber();
            Subscriber subscriberB = new Subscriber();
            publisher.NotifyChange += new MyHandler(subscriberA.SMS);
            publisher.NotifyChange += new MyHandler(subscriberB.Email);
            WeatherStation  station= new WeatherStation();
            if(station.Alert())
            {
                publisher.RaiseNotification();

            }
            publisher.NotifyChange -= new MyHandler(subscriberB.Email);
            publisher.NotifyChange += new MyHandler(subscriberB.WhatsApp);
            
            if(station.Alert())
            {
                publisher.RaiseNotification();
            }
        }
        public class Publisher
        {
            public event MyHandler NotifyChange;
            public void RaiseNotification()
            {
                NotifyChange();
            }

        }
        public class Subscriber
        { 
            public void SMS()
            {
                Console.WriteLine("sms sent because of change in data");
            }
            public void Email()
            {
                Console.WriteLine("email sent because of change in data");
            }
            public void WhatsApp()
            {
                Console.WriteLine("WhatsApp sent because of change in data");

            }
            public class WeatherStation()
            {
                public bool Alert()
                {
                    return true;
                }
            }
        }

    }
}
