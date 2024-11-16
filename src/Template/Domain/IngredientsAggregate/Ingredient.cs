using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.OrderAggregate;
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

        internal Ingredient(string name, decimal amount) : this()
        {
            Name = name;
            Id = Guid.NewGuid();
            Amount = amount;
        }

        internal Ingredient(string name, decimal amount, Guid id) : this()
        {
            Name = name;
            Id = id;
            Amount = amount;

        }

        public static Ingredient CreateIngredients(string name, decimal amount, Guid id)
        => new(name, amount, id);
    }
}
