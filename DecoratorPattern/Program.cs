using DecoratorPattern.Objects.Component;
using DecoratorPattern.Objects.ConcreteComponents;
using DecoratorPattern.Objects.ConcreteDecorators;
using System;


namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);


            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();

        }
    }
}
