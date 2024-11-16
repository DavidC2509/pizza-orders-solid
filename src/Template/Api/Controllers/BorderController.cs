using ControllerCqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Services.Models.Mappers;
using Template.Services.Query.BorderQuery;

namespace Template.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/border")]
    public class BorderController : ServiceBaseController
    {
        public BorderController(IMediator mediator) : base(mediator) { }


        ///<summary>
        ///Listado Cuenta
        ///</summary>
        [HttpGet("list")]
        public Task<ActionResult<IEnumerable<BorderModel>>> ListAccount() => SendRequest(new ListBorderQuery());
    }
}
