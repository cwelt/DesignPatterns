using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        // Constructor 
        public HouseBlend()
        {
            _description = "House Blend Coffee";
            _cost = 0.89;
        }
    }
}
