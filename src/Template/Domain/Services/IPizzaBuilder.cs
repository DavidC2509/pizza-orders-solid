using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Domain.Services
{
    public interface IPizzaBuilder
    {
        PizzaBuilderType UsePizzaBuilder { get; }
        void Reset();
        void SetName(string name);
        void SetBaseAmount(decimal amount);
        void SetPersonalization(bool isPersonalizate);
        void SetRecipe(RecipePizza recipe);
        void SetIngredients(ICollection<Ingredient> ingredients);
        void SetBorder(Border border);
        void AddIngredient(Ingredient ingredient);
        Pizza Build();
    }
}
