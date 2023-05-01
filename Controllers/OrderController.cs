using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetLandApp.Models;

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

            var formattedOrders = orders.Select(o => new
            {
                o.Number,
                o.ClientCode,
                o.ClientName,
                OrderDate = o.OrderDate.ToString("dd.MM.yyyy"),
                ShipmentDate = o.ShipmentDate.ToString("dd.MM.yyyy"),
                o.Quantity,
                o.Confirmed,
                o.Value
            });
            return Ok(formattedOrders);
        }
    }

}
