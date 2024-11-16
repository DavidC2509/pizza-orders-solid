using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.OrderAggregate
{
    public class DeliveryOrder : BaseEntity, IAggregateChild<Order>
    {
        public Order Order { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public string Addres { get; set; }

        private DeliveryOrder()
        {
            Order = null!;
            Addres = string.Empty;
        }

        internal DeliveryOrder(string addres, bool isFree) : this()
        {
            Addres = addres;
            if (isFree)
            {
                Price = 0;
            }
            else
            {
                Price = 10;
            }
            IsFree = isFree;
        }

        public static DeliveryOrder CreateDeliveryOrder(string addres, bool isFree)
            => new(addres, isFree);



    }
}
