using Ardalis.Specification;

namespace Template.Domain.IngredientsAggregate.Specification
{
    public class GetIngredientsByIdsSpec : Specification<Ingredient>
    {
        public GetIngredientsByIdsSpec(IEnumerable<Guid> ingredientIds)
        {
            Query.Where(ingredient => ingredientIds.Contains(ingredient.Id));
        }
    }
}