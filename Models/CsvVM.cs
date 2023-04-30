using MediatR;

namespace NetLandApp.Models
{
    public class CsvVM : IRequest<IEnumerable<Order>>
    {

            public string Number { get; set; }
            public DateTime? OrderDateFrom { get; set; }
            public DateTime? OrderDateTo { get; set; }
            public List<string> ClientCodes { get; set; } = new List<string>();
    }
}
