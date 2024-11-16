using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.IngredientsAggregate;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.IngredientsQuery
{
    public class ListIngredientsQueryHandler : BaseQueryHandler<Ingredient, ListIngredientsQuery, IEnumerable<IngredientsModel>>
    {
        private readonly IMapper _mapper;

        public ListIngredientsQueryHandler(IReadRepository<Ingredient> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public async override Task<IEnumerable<IngredientsModel>> Handle(ListIngredientsQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.ListAsync(cancellationToken);

            var resultMapper = _mapper.Map<List<IngredientsModel>>(list);
            return resultMapper;
        }
    }
}