using Ardalis.Specification;

namespace Template.Domain.RecipePizzaAggregate.Specification
{
    public class GetRecipePizzaIdSpec : Specification<RecipePizza>
    {
        public GetRecipePizzaIdSpec(Guid id)
        {
            Query.Where(recipe => recipe.Id.Equals(id));
        }
    }
}