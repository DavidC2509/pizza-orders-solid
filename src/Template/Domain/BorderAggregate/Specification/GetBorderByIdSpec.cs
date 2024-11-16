using Ardalis.Specification;

namespace Template.Domain.BorderAggregate.Specification
{
    public class GetBorderByIdSpec : Specification<Border>
    {
        public GetBorderByIdSpec(Guid id)
        {
            Query.Where(recipe => recipe.Id.Equals(id));
        }
    }
}