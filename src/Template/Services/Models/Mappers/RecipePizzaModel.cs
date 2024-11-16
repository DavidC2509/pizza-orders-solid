namespace Template.Services.Models.Mappers
{
    public class RecipePizzaModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<IngredientsModel> Ingredients { get; set; }

    }
}
