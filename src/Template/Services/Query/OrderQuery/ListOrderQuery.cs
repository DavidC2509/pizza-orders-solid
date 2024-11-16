using MediatR;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.OrderQuery
{
    public class ListOrderQuery : IRequest<IEnumerable<OrdersModel>>
    {

    }
}
