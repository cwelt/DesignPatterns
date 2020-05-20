using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SteamedMilk : CondimentDecorator
    {
        // Constructor 
        public SteamedMilk(Beverage beverage)
            : base(beverage) 
        {
            _description = "Steamed Milk";
            _cost = 0.10;
        }
    }
}
