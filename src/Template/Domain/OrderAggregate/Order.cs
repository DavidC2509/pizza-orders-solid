using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.ClientAggregate;

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
        internal Order(Client client, List<Pizza> pizzas, bool isFreeDelivery, DeliveryOrder delivery) : this()
        {
            Client = client;
            Pizzas = pizzas;
            IsFreeDeviliry = isFreeDelivery;
            DeliveryOrders = delivery;
            OrderDate = DateTime.Now;
        }

        public static Order CreateOrder(Client client, List<Pizza> pizzas, bool isFreeDelivery, DeliveryOrder delivery)
            => new(client, pizzas, isFreeDelivery, delivery);
    }
}
