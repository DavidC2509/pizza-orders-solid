using MediatR;
using Template.Services.Models;
using Template.Services.Models.Mappers;

namespace Template.Services.Command.OrderCommand
{
    public class StoreOrderCommand : IRequest<OrdersModel>
    {
        public List<StorePizzaModel> Pizzas { get; set; }
        public Guid ClientId { get; set; }
        public string Addres { get; set; }

    }
}
