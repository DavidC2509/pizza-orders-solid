using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.PizzaAggregate;
using Template.Domain.RecipePizzaAggregate;
using Template.Domain.Services;

namespace Template.Services.Services
{
    public class PizzaPersonalizedBuilder : IPizzaBuilder
    {
        private Pizza _pizza = Pizza.CreatePizzaSinDecorar();
        public Pizza Build() => _pizza;
        public void Reset() => _pizza = Pizza.CreatePizzaSinDecorar();
        public void SetName(string name) => _pizza.Name = name;
        public void SetBaseAmount(decimal amount) => _pizza.AmountBase = amount;
        public void SetPersonalization(bool isPersonalizate) => _pizza.IsPersonalizate = isPersonalizate;
        public void SetBorder(Border border) => _pizza.Borders = border;
        public void SetRecipe(RecipePizza recipe)
        {
            if (_pizza.IsPersonalizate)
            {
                throw new InvalidOperationException("No se puede establecer una receta para una pizza personalizada.");
            }
            _pizza.RecipePizza = recipe;
        }

        public void SetIngredients(ICollection<Ingredient> ingredients)
        {
            if (_pizza.IsPersonalizate)
            {
                throw new InvalidOperationException("Las pizzas preestablecidas no pueden tener ingredientes personalizados.");
            }
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (_pizza.IsPersonalizate)
            {
                throw new InvalidOperationException("Las pizzas preestablecidas no pueden tener ingredientes personalizados.");
            }
        }

    }
}
