using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public static class BeverageExtensions
    {
        public static Beverage AddCondiment<TCondiment>(this Beverage beverage, TCondiment condiment) where TCondiment:CondimentDecorator
        {
            return null;
        }
    }
}