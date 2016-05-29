using DecoratorPattern.Objects.Component;
using System;


namespace DecoratorPattern.Objects.Decorator
{
    internal class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
