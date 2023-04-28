using MediatR;
using NetLandApp.Models;

namespace NetLandApp.NetLandApp.Queries
{
    public class GetOrderQuery : IRequest<IEnumerable<Order>>
    {
        public string Number { get; set; }
        public DateTime? OrderDateFrom { get; set; }
        public DateTime? OrderDateTo { get; set; }
        public List<string> ClientCodes { get; set; }
    }
}
