using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.OrderAggregate;
using Template.Domain.OrderAggregate.Specification;
using Template.Services.Models.Mappers;

namespace Template.Services.Query.OrderQuery
{
    public class ListOrderQueryHandler : BaseQueryHandler<Order, ListOrderQuery, IEnumerable<OrdersModel>>
    {
        private readonly IMapper _mapper;

        public ListOrderQueryHandler(IReadRepository<Order> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public async override Task<IEnumerable<OrdersModel>> Handle(ListOrderQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetOrderByAllSpec();
            var list = await _repository.ListAsync(spec, cancellationToken);

            var resultMapper = _mapper.Map<List<OrdersModel>>(list);
            return resultMapper;
        }
    }
}