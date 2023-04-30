using MediatR;
using NetLandApp.Models;

namespace NetLandApp.NetLandApp.Queries
{
    public class GetOrderQuery : IRequest<IEnumerable<CsvVM>>
    {

    }
}
