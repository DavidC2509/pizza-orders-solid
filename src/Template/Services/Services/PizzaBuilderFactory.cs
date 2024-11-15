using Microsoft.Extensions.DependencyInjection;
using Template.Domain.Services;

namespace Template.Services.Services
{
    public class PizzaBuilderFactory : IPizzaBuilderFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PizzaBuilderFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPizzaBuilder GetBuilder(bool isPersonalized)
        {
            return isPersonalized
                ? _serviceProvider.GetRequiredService<PizzaPersonalizedBuilder>() // Builder para pizzas personalizadas
                : _serviceProvider.GetRequiredService<PizzaRecipeBuilder>(); // Builder para pizzas preestablecidas
        }
    }
}