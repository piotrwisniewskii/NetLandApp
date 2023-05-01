using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using NetLandApp.Models;
using System.Globalization;

public class OrderClassMap : ClassMap<Order>
{
    public OrderClassMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Number);
        Map(m => m.ClientCode);
        Map(m => m.ClientName);
        Map(m => m.OrderDate);
        Map(m => m.ShipmentDate);
        Map(m => m.Quantity);
        Map(m => m.Confirmed);
        Map(m => m.Value);
    }
}

