using ControllerCqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Services.Command.OrderCommand;
using Template.Services.Models.Mappers;
using Template.Services.Query.OrderQuery;

namespace Template.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/orden")]
    public class OrderController : ServiceBaseController
    {
        public OrderController(IMediator mediator) : base(mediator) { }


        ///<summary>
        ///Crear Ordenes
        ///</summary>
        [HttpGet("list")]
        public Task<ActionResult<IEnumerable<OrdersModel>>> ListAccount() => SendRequest(new ListOrderQuery());


        ///<summary>
        ///Categoria cuenta
        ///</summary>
        [HttpPost("")]
        public Task<ActionResult<OrdersModel>> StoreAccout([FromBody] StoreOrderCommand command) => SendRequest(command);


    }
}
