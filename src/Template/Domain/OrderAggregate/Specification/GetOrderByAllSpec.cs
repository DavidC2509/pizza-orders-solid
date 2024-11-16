using Ardalis.Specification;

namespace Template.Domain.OrderAggregate.Specification
{
    public class GetOrderByAllSpec : Specification<Order>
    {
        public GetOrderByAllSpec()
        {
            Query.Include(order => order.Pizzas)
                 .ThenInclude(pizza => pizza.Ingredients)
                 .Include(order => order.Pizzas)
                 .ThenInclude(pizza => pizza.RecipePizza)
                 .Include(order => order.Pizzas)
                 .ThenInclude(pizza => pizza.Borders);
        }
    }
}