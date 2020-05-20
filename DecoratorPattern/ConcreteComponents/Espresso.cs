using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
            _cost = 1.99;
        }
    }
}
