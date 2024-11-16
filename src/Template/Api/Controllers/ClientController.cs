using ControllerCqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Services.Models.Mappers;
using Template.Services.Query.ClientQuery;

namespace Template.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/clients")]
    public class ClientController : ServiceBaseController
    {
        public ClientController(IMediator mediator) : base(mediator) { }


        ///<summary>
        ///Listado Cuenta
        ///</summary>
        [HttpGet("list")]
        public Task<ActionResult<IEnumerable<ClientModel>>> ListAccount() => SendRequest(new ListClientQuery());
    }
}
