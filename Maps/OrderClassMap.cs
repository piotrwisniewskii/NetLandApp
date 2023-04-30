using CsvHelper.Configuration;
using NetLandApp.Models;
using System.Globalization;

public class OrderClassMap : ClassMap<Order>
{
    public OrderClassMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Number).Name("Number");
        Map(m => m.ClientCode).Name("ClientCode");
        Map(m => m.ClientName).Name("ClientName");
        Map(m => m.OrderDate).Name("OrderDate");
        Map(m => m.ShipmentDate).Name("ShipmentDate");
        Map(m => m.Quantity).Name("Quantity");
        Map(m => m.Confirmed).Name("Confirmed");
        Map(m => m.Value).Name("Value");
    }
}
