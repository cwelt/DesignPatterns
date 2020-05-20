using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");

        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Brew()
        {
            BrewCoffeeGrinds();
        }

        protected override void AddCondiments()
        {
            AddSugarAndMilk();
        }
    }
}

