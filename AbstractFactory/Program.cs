using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two pizza stores (i.e., 2 concrete creators)
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            // create concrete products 
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}\n", pizza.Name);

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Yoel ordered a {0}\n", pizza.Name);
        }
    }
}
