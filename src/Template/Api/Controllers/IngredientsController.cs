using ControllerCqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Services.Models.Mappers;
using Template.Services.Query.IngredientsQuery;

namespace Template.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/ingredient")]
    public class IngredientsController : ServiceBaseController
    {
        public IngredientsController(IMediator mediator) : base(mediator) { }


        ///<summary>
        ///Listado Cuenta
        ///</summary>
        [HttpGet("list")]
        public Task<ActionResult<IEnumerable<IngredientsModel>>> ListAccount() => SendRequest(new ListIngredientsQuery());
    }
}
