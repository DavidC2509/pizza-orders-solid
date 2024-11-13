using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.OrderAggregate
{
    public class DeliveryOrder : BaseEntity, IAggregateChild<Order>
    {
        public Order Order { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }

        private DeliveryOrder()
        {
            Order = null!;
        }

    }
}
