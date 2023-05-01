using CsvHelper.Configuration.Attributes;
using NetLandApp.Helpers;

namespace NetLandApp.Models
{
    public class Order
    {
        [Name("Number")]
        public string Number { get; set; }

        [Name("ClientCode")]
        public string ClientCode { get; set; }

        [Name("ClientName")]
        public string ClientName { get; set; }

        [Name("OrderDate")]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DateTimeConverter))]
        public DateTime OrderDate { get; set; }

        [Name("ShipmentDate")]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DateTimeConverter))]
        public DateTime ShipmentDate { get; set; }

        [Name("Quantity")]
        public int Quantity { get; set; }

        [Name("Confirmed")]
        public bool Confirmed { get; set; }

        [Name("Value")]
        public decimal Value { get; set; }
    }


}
