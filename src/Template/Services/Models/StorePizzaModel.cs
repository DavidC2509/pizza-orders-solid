namespace Template.Services.Models
{
    public class StorePizzaModel
    {
        public bool IsPersonalizate { get; set; }
        public Guid BorderId { get; set; }
        public Guid? RecipeId { get; set; } = null;
        public List<Guid>? IngredientsId { get; set; } = null;
    }
}
