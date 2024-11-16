using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.RecipePizzaAggregate;
using Template.Domain.RecipePizzaAggregate.Specification;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.RecipePizzaQuery
{
    public class ListRecipePizzaQueryHandler : BaseQueryHandler<RecipePizza, ListRecipePizzaQuery, IEnumerable<RecipePizzaModel>>
    {
        private readonly IMapper _mapper;

        public ListRecipePizzaQueryHandler(IReadRepository<RecipePizza> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public async override Task<IEnumerable<RecipePizzaModel>> Handle(ListRecipePizzaQuery request, CancellationToken cancellationToken)
        {
            var spec = new RecipePizzaIngredientsSpec();
            var list = await _repository.ListAsync(spec, cancellationToken);

            var resultMapper = _mapper.Map<List<RecipePizzaModel>>(list);
            return resultMapper;
        }
    }
}