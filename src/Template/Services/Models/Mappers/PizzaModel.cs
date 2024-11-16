namespace Template.Services.Models.Mappers
{
    public class PizzaModel
    {
        public string Name { get; set; }
        public bool IsPersonalizate { get; set; }
        public decimal AmountBase { get; set; }
        public ICollection<IngredientsModel> Ingredients { get; set; }
        public BorderModel? Borders { get; set; }
        public RecipePizzaModel? RecipePizza { get; set; }
    }
}
