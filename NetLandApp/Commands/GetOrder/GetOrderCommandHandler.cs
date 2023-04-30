using MediatR;
using NetLandApp.Models;
using NetLandApp.Services;

namespace NetLandApp.NetLandApp.Commands.GetOrder
{
    public class GetOrderHandler : IRequestHandler<CsvVM, IEnumerable<Order>>
    {
        private readonly ICsvService _csvService;
        private readonly IConfiguration _configuration;

        public GetOrderHandler(ICsvService csvService, IConfiguration configuration)
        {
            _csvService = csvService;
            _configuration = configuration;
        }

        public Task<IEnumerable<Order>> Handle(CsvVM request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
