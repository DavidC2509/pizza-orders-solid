using Ardalis.Specification;

namespace Template.Domain.OrderAggregate.Specification
{
    public class GetOrderByAllSpec : Specification<Order>
    {
        public GetOrderByAllSpec()
        {
            Query.Include(order => order.DeliveryOrders).Include(order => order.Pizzas);
            //.ThenInclude(piiza => piiza.Ingredients);
        }
    }
}