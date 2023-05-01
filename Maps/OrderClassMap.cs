using CsvHelper.Configuration;
using NetLandApp.Models;
using System.Globalization;

public class OrderClassMap : ClassMap<Order>
{
    public OrderClassMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Number).Index(0);
        Map(m => m.ClientCode).Index(1);
        Map(m => m.ClientName).Index(2);
        Map(m => m.OrderDate).Index(3);
        Map(m => m.ShipmentDate).Index(4);
        Map(m => m.Quantity).Index(5);
        Map(m => m.Confirmed).Index(6);
        Map(m => m.Value).Index(7);
    }
}

