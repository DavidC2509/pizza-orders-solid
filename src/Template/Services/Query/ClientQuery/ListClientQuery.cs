using MediatR;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.ClientQuery
{
    public class ListClientQuery : IRequest<IEnumerable<ClientModel>>
    {

    }
}
