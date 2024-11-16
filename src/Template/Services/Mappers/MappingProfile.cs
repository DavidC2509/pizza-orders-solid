using AutoMapper;
using Template.Domain.BorderAggregate;
using Template.Domain.ClientAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;
using Template.Services.Models.Mappers;

namespace Template.Services.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Ingredient, IngredientsModel>();
            CreateMap<Border, BorderModel>();
            CreateMap<RecipePizza, RecipePizzaModel>();
            CreateMap<Pizza, PizzaModel>();
            CreateMap<DeliveryOrder, DeliveryOrderModel>();
            CreateMap<Order, OrdersModel>();
            CreateMap<Client, ClientModel>();

        }
    }
}
