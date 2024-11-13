using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.PizzaAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Domain.IngredientsAggregate
{
    public class Ingredient : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public ICollection<Pizza> Pizzas { get; set; }
        public ICollection<RecipePizza> RecipePizzas { get; set; }

        private Ingredient()
        {
            Name = string.Empty;
            Pizzas = [];
            RecipePizzas = [];
        }
    }
}
