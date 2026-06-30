using System.Security.Cryptography.X509Certificates;

namespace Demo21
{
    public delegate void  MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is special guest Here? ");
            bool isHere = true;

            AnnualFunction obj = new AnnualFunction();

          
            MyEventHandler handler = new MyEventHandler(obj.WelCome);
            handler += new MyEventHandler(obj.HostSpeech);
            handler += obj.GuestSpeech;

            if (isHere)
                handler += obj.SpecialGuestSpeech;
            else
                handler -= obj.SpecialGuestSpeech;

            handler += obj.Dance;
            handler += obj.DinnerParty;
            handler += obj.GoodBye;
            handler += obj.Packup;
            handler();

        }
    }

    public class AnnualFunction()
    {
        public void WelCome()
        {
            Console.WriteLine("Wel-come to our function !!!");
        }
        public void HostSpeech()
        {
            Console.WriteLine("Host:hii everyone ");
        }
        public void GuestSpeech()
        {
            Console.WriteLine("Guest:good Evening!!!!!");
        }
        public void SpecialGuestSpeech()
        {
            Console.WriteLine("SpecialGuest:Yahhhhh Enjoy your Annual Function Guys lets go all dance");
        }
        public void Dance()
        {
            Console.WriteLine("lets dance");
        }
        public void DinnerParty()
        {
            Console.WriteLine("Enjoy your food!!");
        }
        public void GoodBye()
        {
            Console.WriteLine("Host: Event is over!!!!!!");
        }
        public void Packup()
        {
            Console.WriteLine("Packup... Finally!!!");
        }
    }
}

