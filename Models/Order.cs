using CsvHelper.Configuration.Attributes;

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
        public DateTime OrderDate { get; set; }

        [Name("ShipmentDate")]
        public DateTime ShipmentDate { get; set; }

        [Name("Quantity")]
        public int Quantity { get; set; }

        [Name("Confirmed")]
        public bool Confirmed { get; set; }

        [Name("Value")]
        public decimal Value { get; set; }
    }

}
