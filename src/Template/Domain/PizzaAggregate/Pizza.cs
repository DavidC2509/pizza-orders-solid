using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Domain.PizzaAggregate
{
    public class Pizza : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public bool IsPersonalizate { get; set; }
        public decimal AmountBase { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public RecipePizza? RecipePizza { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Border Borders { get; set; }

        private Pizza()
        {
            Name = string.Empty;
            Ingredients = [];
            Orders = [];
            Borders = null!;
        }
    }
}
