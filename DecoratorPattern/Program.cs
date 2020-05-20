using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();

            // Order an espresso with no condiments
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1);

            // Order a dark roast with double mocha & whip on top
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2);

            // House blend with soy mocha & whip
            Beverage beverage3 = new Whip(new Mocha(new Soy(new HouseBlend())));
            Console.WriteLine(beverage3);

        }

        public static void PrintMenu()
        {
            // Beverages 
            Console.WriteLine("Beverages");
            Console.WriteLine("==========");
            Console.WriteLine($"DarkRoast: $ " + new DarkRoast().Cost);
            Console.WriteLine($"Decaf: $ " + new Decaf().Cost);
            Console.WriteLine($"Espresso: $ " + new Espresso().Cost);
            Console.WriteLine($"HouseBlend: $ " + new HouseBlend().Cost);

            // Condiments 
            Console.WriteLine("\n\nCondiments");
            Console.WriteLine("==========");
            Console.WriteLine($"Mocha: $ 0.20");
            Console.WriteLine($"Soy: $ 0.15");
            Console.WriteLine($"Steamed Milk: $ 0.10");
            Console.WriteLine($"Whip: $ 0.10");
            Console.WriteLine("\n\n");
        }
    }
}
