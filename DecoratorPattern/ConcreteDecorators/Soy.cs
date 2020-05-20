using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        // Constructor 
        public Soy(Beverage beverage)
            : base(beverage)
        {
            _description = "Soy";
            _cost = 0.15;
        }
    }
}
