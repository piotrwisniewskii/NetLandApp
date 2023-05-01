using MediatR;
using NetLandApp.Models;

namespace NetLandApp.NetLandApp.Commands.GetOrder
{
    public class GetOrderCommand : IRequest<IEnumerable<Order>>
    {
    }
}
