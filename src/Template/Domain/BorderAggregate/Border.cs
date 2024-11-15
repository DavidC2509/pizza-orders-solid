using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.PizzaAggregate;

namespace Template.Domain.BorderAggregate
{
    public class Border : BaseEntity, IAggregateRoot
    {
        public string Description { get; set; }

        // Relaciones
        public ICollection<Pizza> Pizzas { get; set; }

        private Border()
        {
            Description = string.Empty;
            Pizzas = [];
        }

        internal Border(string description) : this()
        {
            Description = description;
            Id = Guid.NewGuid();
        }

        public static Border CreateBorder(string description)
        => new(description);

    }
}
