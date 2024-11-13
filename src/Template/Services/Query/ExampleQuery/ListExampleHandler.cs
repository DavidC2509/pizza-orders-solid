﻿using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.PizzaAggregate;
using Template.Services.Models;

namespace Template.Services.Query.ExampleQuery
{
    public class ListExampleHandler : BaseQueryHandler<Pizza, ListExampleQuery, IEnumerable<ExampleModels>>
    {
        private readonly IMapper _mapper;

        public ListExampleHandler(IReadRepository<Pizza> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override async Task<IEnumerable<ExampleModels>> Handle(ListExampleQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.ListAsync();
            var resultMapper = _mapper.Map<List<ExampleModels>>(list);
            return resultMapper;

        }
    }
}