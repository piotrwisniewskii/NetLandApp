using CsvHelper;
using CsvHelper.Configuration;
using NetLandApp.Models;
using System.Globalization;
using System.Text;

namespace NetLandApp.Services
{
    public class CsvService
    {
        public IEnumerable<Order> Read(string filePath)
        {
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                Quote = '"',
                HasHeaderRecord = true
            };

            using var csv = new CsvReader(reader, config);
            csv.Context.TypeConverterOptionsCache.GetOptions<DateTime>().Formats = new[] { "dd.MM.yyyy" };

            return csv.GetRecords<Order>().ToList();
        }
    }
}
