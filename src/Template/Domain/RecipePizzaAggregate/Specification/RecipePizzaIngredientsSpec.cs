using Ardalis.Specification;

namespace Template.Domain.RecipePizzaAggregate.Specification
{
    public class RecipePizzaIngredientsSpec : Specification<RecipePizza>
    {
        public RecipePizzaIngredientsSpec()
        {
            Query.Include(recipe => recipe.Ingredients);
        }
    }
}