using MediatR;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.RecipePizzaQuery
{
    public class ListRecipePizzaQuery : IRequest<IEnumerable<RecipePizzaModel>>
    {

    }
}
