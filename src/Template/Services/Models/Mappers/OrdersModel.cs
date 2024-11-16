namespace Template.Services.Models.Mappers
{
    public class OrdersModel
    {
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public bool IsFreeDeviliry { get; set; }
        public ICollection<PizzaModel> Pizzas { get; set; }
        public DeliveryOrderModel DeliveryOrders { get; set; }

    }
}
