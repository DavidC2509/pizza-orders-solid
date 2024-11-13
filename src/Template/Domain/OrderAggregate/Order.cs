using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.ClientAggregate;
using Template.Domain.PizzaAggregate;

namespace Template.Domain.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {

        public Client Client { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public bool IsFreeDeviliry { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
        public DeliveryOrder? DeliveryOrders { get; set; }

        private Order()
        {
            Client = null!;
            Pizzas = [];
        }
    }
}
