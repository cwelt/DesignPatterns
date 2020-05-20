using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("\nMaking Tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking Coffee...");
            coffee.PrepareRecipe();

        }
    }
}
