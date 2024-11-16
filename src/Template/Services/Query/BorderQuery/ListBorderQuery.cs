using MediatR;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.BorderQuery
{
    public class ListBorderQuery : IRequest<IEnumerable<BorderModel>>
    {

    }
}
