using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.IngredientsAggregate;
using Template.Domain.PizzaAggregate;

namespace Template.Domain.RecipePizzaAggregate
{
    public class RecipePizza : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }


        private RecipePizza()
        {
            Name = string.Empty;
            Description = string.Empty;
            Ingredients = [];
            Pizzas = [];

        }

    }
}
