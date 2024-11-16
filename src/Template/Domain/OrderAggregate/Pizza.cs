using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;
using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Domain.OrderAggregate
{
    public class Pizza : BaseEntity, IAggregateChild<Order>
    {
        public string Name { get; set; }
        public bool IsPersonalizate { get; set; }
        public decimal AmountBase { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

        public Guid? RecipePizzaId { get; set; }

        virtual
        public RecipePizza? RecipePizza
        { get; set; }

        public Border? Borders { get; set; }
        public int CountPizza { get; set; }
        public Order Order { get; set; }

        private Pizza()
        {
            Name = string.Empty;
            Ingredients = [];
            Order = null!;
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
