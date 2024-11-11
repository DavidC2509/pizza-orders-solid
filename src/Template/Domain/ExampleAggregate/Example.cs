using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.ExampleAggregate
{
    public class Example : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string? Phone { get; set; }

        public Example(string name, string? phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
