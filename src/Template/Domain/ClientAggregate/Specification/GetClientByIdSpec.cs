using Ardalis.Specification;

namespace Template.Domain.ClientAggregate.Specification
{
    public class GetClientByIdSpec : Specification<Client>
    {
        public GetClientByIdSpec(Guid id)
        {
            Query.Where(client => client.Id.Equals(id));
        }
    }
}