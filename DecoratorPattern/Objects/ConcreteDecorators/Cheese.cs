using DecoratorPattern.Objects.Decorator;

using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.ConcreteDecorators
{
    internal class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {           
            return string.Format("{0}, {1}",_pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25;
        }
    }
}
