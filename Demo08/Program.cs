namespace Demo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice:1.cola,2.Tea");
            int ch = Convert.ToInt32(Console.ReadLine());
            DrinkFactory factory = new DrinkFactory();
            IDrink drink = factory.GetSomeDrink(ch);
            Console.WriteLine($"enjoy your drink={drink.GetDrink()}");
        }
    }
    public interface IDrink
    {
        string GetDrink();

    }
    public class DrinkFactory
    {
        public IDrink GetSomeDrink(int ch)
        {
            IDrink drink = null;
            switch(ch)
            {
                case 1:
                    drink = new ColdDrink();
                    break;
                case 2:
                    drink = new HotDrink();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
                        
            }
            return drink;
        }

    }
    public class ColdDrink : IDrink
    {
        public String GetDrink()
        {
            return "Cola";
        }
    }
        public class HotDrink : IDrink
        { 
        public string GetDrink()
            {
                return "Tea";
            }
        }  
            
                    
}
