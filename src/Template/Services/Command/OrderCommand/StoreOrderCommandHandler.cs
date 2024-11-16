using AutoMapper;
using Core.Cqrs.CommandAndQueryHandler;
using Core.Cqrs.Domain.Repository;
using Template.Domain.BorderAggregate;
using Template.Domain.BorderAggregate.Specification;
using Template.Domain.ClientAggregate;
using Template.Domain.ClientAggregate.Specification;
using Template.Domain.IngredientsAggregate;
using Template.Domain.IngredientsAggregate.Specification;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;
using Template.Domain.RecipePizzaAggregate.Specification;
using Template.Services.Builder;
using Template.Services.Models;
using Template.Services.Models.Mappers;

namespace Template.Services.Command.OrderCommand
{
    public class StoreOrderCommandHandler : BaseCommandHandler<IRepository<Order>, StoreOrderCommand, OrdersModel>
    {

        private readonly IReadRepository<Ingredient> _ingredientRepository;
        private readonly IReadRepository<RecipePizza> _recipeRepository;
        private readonly IReadRepository<Border> _borderRepository;
        private readonly IReadRepository<Client> _clientRepository;

        private readonly PizzaDirector _pizzaDirector;
        private readonly IMapper _mapper;

        public StoreOrderCommandHandler(IReadRepository<Ingredient> ingredientRepository,
            IReadRepository<RecipePizza> recipeRepository, IReadRepository<Border> borderRepository, PizzaDirector pizzaDirector, IMapper mapper, IRepository<Order> repository, IReadRepository<Client> clientRepository) : base(repository)
        {
            _ingredientRepository = ingredientRepository;
            _recipeRepository = recipeRepository;
            _borderRepository = borderRepository;
            _pizzaDirector = pizzaDirector;
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public async override Task<OrdersModel> Handle(StoreOrderCommand request, CancellationToken cancellationToken)
        {
            var pizzas = await createPizzas(request.Pizzas, cancellationToken);
            var deliveryAddres = createAddres(request.Addres);
            var clientSpec = new GetClientByIdSpec(request.ClientId);
            var client = await _clientRepository.FirstOrDefaultAsync(clientSpec, cancellationToken);
            var order = Order.CreateOrder(client, pizzas, true, deliveryAddres);
            _repository.Update(order);
            await _repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            return _mapper.Map<OrdersModel>(order);

        }

        public async Task<List<Pizza>> createPizzas(List<StorePizzaModel> pizzas, CancellationToken cancellationToken)
        {
            var listPizza = new List<Pizza>();
            foreach (var item in pizzas)
            {
                var borderSpec = new GetBorderByIdSpec(item.BorderId);
                var border = await _borderRepository.FirstOrDefaultAsync(borderSpec, cancellationToken);

                if (item.IsPersonalizate)
                {
                    var ingredientsSpec = new GetIngredientsByIdsSpec(item.IngredientsId);
                    var ingredients = await _ingredientRepository.ListAsync(ingredientsSpec, cancellationToken);
                    _pizzaDirector.BuildCustomPizza(ingredients, border);
                }
                else
                {
                    var recipeSpec = new GetRecipePizzaIdSpec(item.RecipeId.Value);
                    var recipePizza = await _recipeRepository.FirstOrDefaultAsync(recipeSpec, cancellationToken);
                    _pizzaDirector.BuildRecipePizza(recipePizza, border);
                }
                listPizza.Add(_pizzaDirector.ObtenerPizza());
            }
            return listPizza;
        }

        public DeliveryOrder createAddres(string addres)
        {
            var deliveryOrder = DeliveryOrder.CreateDeliveryOrder(addres, true);
            return deliveryOrder;
        }
    }
}
