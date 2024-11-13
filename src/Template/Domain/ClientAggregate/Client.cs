using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.OrderAggregate;

namespace Template.Domain.ClientAggregate
{
    public class Client : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }

        public ICollection<Order> Orders { get; set; }
        private Client()
        {
            Name = string.Empty;
            Email = string.Empty;
            CellPhone = string.Empty;
            Orders = [];
        }

    }
}
