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
        public Border? Borders { get; set; }

        private Pizza()
        {
            Name = string.Empty;
            Ingredients = [];
            Orders = [];
        }

        public static Pizza CreatePizzaSinDecorar()
        => new();

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetIsPersonalizate(bool isPersonalizate)
        {
            IsPersonalizate = isPersonalizate;
        }

        public void SetBorder(Border border)
        {
            Borders = border;
        }

        public void SetRecipePizza(RecipePizza recipePizza)
        {
            RecipePizza = recipePizza;
        }

        public void AddIngredients(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }



    }
}
