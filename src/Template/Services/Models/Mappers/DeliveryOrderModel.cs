namespace Template.Services.Models.Mappers
{
    public class DeliveryOrderModel
    {
        public Guid Id { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public string Addres { get; set; }
    }
}