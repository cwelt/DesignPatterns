using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The Abstract Component Supertype 
    /// </summary>
    public abstract class Beverage 
    {
        // private instance data  
        private protected string _description;
        private protected double _cost;

        // public readonly properties 
        public virtual string Description { get => _description; }
        public virtual double Cost { get => _cost; }

        // size property 
        protected BeverageSize Size { get; set; }

        public override string ToString()
        {
            return $"{Description}, {Cost}";
        }
    }

    public enum BeverageSize
    {
        Small,
        Medium,
        Large
    }
}
