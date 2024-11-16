using ControllerCqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Services.Models.Mappers;
using Template.Services.Query.RecipePizzaQuery;

namespace Template.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/recipe-pizza")]
    public class RecipePizzaController : ServiceBaseController
    {
        public RecipePizzaController(IMediator mediator) : base(mediator) { }


        ///<summary>
        ///Listado Cuenta
        ///</summary>
        [HttpGet("list")]
        public Task<ActionResult<IEnumerable<RecipePizzaModel>>> ListAccount() => SendRequest(new ListRecipePizzaQuery());
    }
}
