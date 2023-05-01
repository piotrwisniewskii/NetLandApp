using CsvHelper;
using CsvHelper.Configuration;
using NetLandApp.Models;
using System.Globalization;
using System.Text;

namespace NetLandApp.Services
{
    public class CsvService : ICsvService
    {
        public IEnumerable<Order> Read(string filePath)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, configuration);
            csv.Context.RegisterClassMap<OrderClassMap>();
            var records = csv.GetRecords<Order>().ToList();
            return records;
        }
    }
}
