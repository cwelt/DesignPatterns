using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Concrete Decorator 
    /// </summary>
    public class Whip : CondimentDecorator
    {
        // Constructor 
        public Whip(Beverage beverage)
            : base(beverage)
        {
            _description = "Whip";
            _cost = 0.10;
        }
    }
}
