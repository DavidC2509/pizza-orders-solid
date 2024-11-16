using MediatR;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.IngredientsQuery
{
    public class ListIngredientsQuery : IRequest<IEnumerable<IngredientsModel>>
    {

    }
}
