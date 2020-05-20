using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        // Constructor 
        public Mocha(Beverage beverage) : base(beverage)
        {
            _description = "Mocha";
            _cost = 0.20;
        }
    }
}
