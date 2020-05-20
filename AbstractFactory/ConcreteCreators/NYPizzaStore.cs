using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (type.Equals("olives"))
            {
                return new NYStyleOlivesPizza();
            }
            else return null;
        }
    }
}
