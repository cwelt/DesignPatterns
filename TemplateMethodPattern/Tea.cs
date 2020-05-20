using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
    {
        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");

        }

        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            SteepTeaBag();
        }

        protected override void AddCondiments()
        {
            AddLemon();
        }

        protected override bool CustomerWantsCondiments()
        {
            string userAnswer = GetUserInput();
            return userAnswer?.ToUpper().StartsWith("Y") ?? false;
        }

        private string GetUserInput()
        {
            Console.Write("Would you like milk and sugar with your coffee (y/n)?");
            return Console.ReadLine();
        }
    }
}
