﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "NY Style Sauce and Veggiee Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Margarine");
        }
    }
}
