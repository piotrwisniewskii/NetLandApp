using MediatR;
using NetLandApp.Models;
using NetLandApp.NetLandApp.Queries;
using NetLandApp.Services;

namespace NetLandApp.NetLandApp.Commands.GetOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, IEnumerable<Order>>
    {
        private readonly CsvService _csvService;
        private readonly IConfiguration _configuration;

        public GetOrderHandler(CsvService csvService, IConfiguration configuration)
        {
            _csvService = csvService;
            _configuration = configuration;
        }

        public Task<IEnumerable<Order>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            string filePath = _configuration.GetValue<string>("OrdersCsvPath");
            var orders = _csvService.Read(filePath);

            if (!string.IsNullOrEmpty(request.Number))
            {
                orders = orders.Where(o => o.Number == request.Number);
            }

            if (request.OrderDateFrom.HasValue && request.OrderDateTo.HasValue)
            {
                orders = orders.Where(o => o.OrderDate >= request.OrderDateFrom.Value && o.OrderDate <= request.OrderDateTo.Value);
            }

            if (request.ClientCodes != null && request.ClientCodes.Any())
            {
                orders = orders.Where(o => request.ClientCodes.Contains(o.ClientCode));
            }

            return Task.FromResult(orders);
        }
    }

}
