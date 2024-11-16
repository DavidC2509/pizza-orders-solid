using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.BorderAggregate;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.BorderQuery
{
    public class ListBorderQueryHandler : BaseQueryHandler<Border, ListBorderQuery, IEnumerable<BorderModel>>
    {
        private readonly IMapper _mapper;

        public ListBorderQueryHandler(IReadRepository<Border> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public async override Task<IEnumerable<BorderModel>> Handle(ListBorderQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.ListAsync(cancellationToken);

            var resultMapper = _mapper.Map<List<BorderModel>>(list);
            return resultMapper;
        }
    }
}