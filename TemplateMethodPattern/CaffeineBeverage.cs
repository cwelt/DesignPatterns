using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        /// <summary>
        /// Hook default implementation  
        /// </summary>
        /// <returns></returns>
        protected virtual bool CustomerWantsCondiments() => true;
        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }


    }
}
