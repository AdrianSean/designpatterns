using DecoratorPattern.Objects.Decorator;

using DecoratorPattern.Objects.Component;

namespace DecoratorPattern.Objects.ConcreteDecorators
{
    internal class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.00;
        }
    }
}
