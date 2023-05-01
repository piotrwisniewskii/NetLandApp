//using MediatR;
//using NetLandApp.Models;
//using NetLandApp.Services;

//namespace NetLandApp.NetLandApp.Commands.GetOrder
//{
//    public class GetOrderCommandHandler : IRequestHandler<GetOrderCommand, IEnumerable<Order>>
//    {
//        private readonly ICsvService _csvService;
//        private readonly IConfiguration _configuration;

//        public GetOrderCommandHandler(ICsvService csvService, IConfiguration configuration)
//        {
//            _csvService = csvService;
//            _configuration = configuration;
//        }

//        public Task<IEnumerable<Order>> Handle(GetOrderCommand request, CancellationToken cancellationToken)
//        {
//           throw new Exception();
//        }
//    }

//}
