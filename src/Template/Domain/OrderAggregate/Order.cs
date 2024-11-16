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
            OrderDate = DateTime.UtcNow;
            CalculateTotal();
        }

        public static Order CreateOrder(Client client, List<Pizza> pizzas, bool isFreeDelivery, DeliveryOrder delivery)
            => new(client, pizzas, isFreeDelivery, delivery);

        public void CalculateTotal()
        {
            decimal total = 0;

            foreach (var pizza in Pizzas)
            {
                decimal pizzaTotal = pizza.AmountBase;

                if (pizza.IsPersonalizate)
                {
                    // Sumar ingredientes personalizados
                    pizzaTotal += pizza.Ingredients.Sum(i => i.Amount);
                }
                else if (pizza.RecipePizza != null)
                {
                    if (pizza.RecipePizza.Ingredients != null)
                    {
                        pizzaTotal += pizza.RecipePizza.Ingredients.Sum(i => i.Amount);
                    }
                }

                // Multiplicar por la cantidad de pizzas
                total += pizzaTotal * pizza.CountPizza;
            }

            Total = total;
        }

    }
}
