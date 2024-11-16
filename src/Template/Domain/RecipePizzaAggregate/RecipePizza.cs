using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;

namespace Template.Domain.RecipePizzaAggregate
{
    public class RecipePizza : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }

        private RecipePizza()
        {
            Name = string.Empty;
            Description = string.Empty;
            Ingredients = [];
            Pizzas = [];
            Id = Guid.NewGuid();

        }

        internal RecipePizza(string name, string description, decimal price) : this()
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public static RecipePizza CreateRecipePizza(string name, string description, decimal price)
        => new(name, description, price);

    }
}
