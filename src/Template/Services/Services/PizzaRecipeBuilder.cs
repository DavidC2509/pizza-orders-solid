using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;
using Template.Domain.Services;

namespace Template.Services.Services
{
    public class PizzaRecipeBuilder : IPizzaBuilder
    {
        public PizzaBuilderType UsePizzaBuilder => PizzaBuilderType.RecipePizza;

        private Pizza _pizza = Pizza.CreatePizzaSinDecorar();
        public Pizza Build() => _pizza;
        public void Reset() => _pizza = Pizza.CreatePizzaSinDecorar();
        public void SetName(string name) => _pizza.SetName(name);
        public void SetBaseAmount(decimal amount) => _pizza.SetAmount(amount);
        public void SetPersonalization(bool isPersonalizate) => _pizza.SetIsPersonalizate(isPersonalizate);
        public void SetBorder(Border border) => _pizza.SetBorder(border);
        public void SetCountPizza(int count) => _pizza.SetCount(count);
        public void SetRecipe(RecipePizza recipe)
        {
            if (_pizza.IsPersonalizate)
            {
                throw new InvalidOperationException("No se puede establecer una receta para una pizza personalizada.");
            }
            _pizza.SetRecipePizza(recipe);
        }

        public void SetIngredients(ICollection<Ingredient> ingredients)
        {
            _pizza.SetIngredients(ingredients);
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _pizza.AddIngredients(ingredient);
        }

    }
}
