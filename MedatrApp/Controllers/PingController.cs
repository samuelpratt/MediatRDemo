using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MedatrApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values/5
        [HttpGet("{host}")]
        public async Task<ActionResult<string>> GetAsync(String host)
        {
            var cmd = new Cqrs.Ping(host);

            var response = await _mediator.Send(cmd);

            return response;
        }
    }
}
