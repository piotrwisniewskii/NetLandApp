using MediatR;
using NetLandApp.Models;
using NetLandApp.Services;

namespace NetLandApp.NetLandApp.Queries
{
    public class GetOrderQueryHandler : IRequestHandler<CsvVM, IEnumerable<Order>>
    {
        private readonly ICsvService _csvService;
        private readonly IConfiguration _configuration;

        public GetOrderQueryHandler(ICsvService csvService, IConfiguration configuration)
        {
            _csvService = csvService;
            _configuration = configuration;
        }
        public Task<IEnumerable<Order>> Handle(CsvVM request, CancellationToken cancellationToken)
        {
            string filePath = _configuration.GetValue<string>("CSVSettings:OrderCsvPath");

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
