using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
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
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, configuration);
            csv.Context.RegisterClassMap<OrderClassMap>();
            var records = csv.GetRecords<Order>().ToList();
            return records;
        }

        public async Task ExportOrdersToCsv(IEnumerable<Order> orders, Stream stream)
        {
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                await csv.WriteRecordsAsync(orders);
            }
        }

        public async Task ExportOrderToCsv(Order order, Stream stream)
        {
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<Order>();
                csv.NextRecord();
                csv.WriteRecord(order);
                await writer.FlushAsync();
            }
        }

    }
}
