using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetLandApp.Models;
using NetLandApp.NetLandApp.Commands.GetOrder;
using NetLandApp.NetLandApp.Queries;

namespace NetLandApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CsvVM query)
        {
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }
    }

}
