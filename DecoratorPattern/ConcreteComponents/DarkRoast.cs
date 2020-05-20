using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(BeverageSize size = BeverageSize.Medium)
        {
            _description = "Dark Roast";
            switch (size)
            {
                case BeverageSize.Small:
                    _cost = 0.5;
                    break;
                case BeverageSize.Medium:
                    _cost = 0.99;
                    break;
                case BeverageSize.Large:
                    _cost = 1.5;
                    break;
                default:
                    break;
            }
        }
    }
}
