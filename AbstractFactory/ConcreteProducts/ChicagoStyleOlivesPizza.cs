using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NYStyleOlivesPizza : Pizza
    {
        public NYStyleOlivesPizza()
        {
            Name = "NY Style Sauce and Olives Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano olives");
        }
    }
}
