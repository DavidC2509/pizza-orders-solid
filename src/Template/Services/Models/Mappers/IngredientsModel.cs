namespace Template.Services.Models.Mappers
{
    public class IngredientsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public IngredientsModel()
        {
            Name = string.Empty;
        }
    }
}
