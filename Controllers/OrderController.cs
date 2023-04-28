using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Get([FromQuery] GetOrderQuery query)
        {
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }
    }

}
