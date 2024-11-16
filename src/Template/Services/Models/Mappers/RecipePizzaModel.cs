namespace Template.Services.Models.Mappers
{
    public class RecipePizzaModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Propiedad calculada
        public decimal Price => Ingredients?.Sum(i => i.Amount) ?? 0;

        public ICollection<IngredientsModel> Ingredients { get; set; }

    }
}
