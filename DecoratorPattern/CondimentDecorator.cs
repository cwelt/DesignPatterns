using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{   
    /// <summary>
    /// The Abstract Decorator Class 
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public override string Description => Beverage.Description + ", " + _description;
        public override double Cost => Beverage.Cost + _cost;
        protected Beverage Beverage { get; set; }

        public CondimentDecorator(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public Beverage AddCondiment(Beverage beverage)
        {
            return null;
        }
    }
}
