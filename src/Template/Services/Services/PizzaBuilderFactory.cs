using Template.Domain.Services;

namespace Template.Services.Services
{
    public class PizzaBuilderFactory : IPizzaBuilderFactory
    {
        private readonly IEnumerable<IPizzaBuilder> _pizzaBuilder;

        public PizzaBuilderFactory(IEnumerable<IPizzaBuilder> pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public IPizzaBuilder GetBuilder(bool isPersonalized)
        {
            return isPersonalized
                ? _pizzaBuilder.FirstOrDefault(s => s.UsePizzaBuilder == PizzaBuilderType.Personalizate) // Builder para pizzas personalizadas
                : _pizzaBuilder.FirstOrDefault(s => s.UsePizzaBuilder == PizzaBuilderType.RecipePizza); // Builder preestablecidas
        }
    }
}