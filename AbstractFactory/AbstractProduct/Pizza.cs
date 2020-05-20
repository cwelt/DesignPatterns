using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// The Abstract Product Class 
    /// </summary>
    public abstract class Pizza
    {
        public virtual String Name { get; protected set; } 
        public virtual String Dough { get; protected set; }
        public virtual String Sauce { get; protected set; }

        public List<String> Toppings { get; protected set; } = new List<String>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < Toppings.Count; i++)
            {
                Console.WriteLine(" " +Toppings[i]);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350") ;
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
