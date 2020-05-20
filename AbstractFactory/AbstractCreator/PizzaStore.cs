using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(String type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        /// <summary>
        ///  abstarct factory method 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected abstract Pizza CreatePizza(String type);
    }
}
