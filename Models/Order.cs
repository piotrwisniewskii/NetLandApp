﻿using CsvHelper.Configuration.Attributes;

namespace NetLandApp.Models
{
    public class Order
    {

        public string Number { get; set; }


        public string ClientCode { get; set; }

        public string ClientName { get; set; }


        public DateTime OrderDate { get; set; }

        public DateTime ShipmentDate { get; set; }


        public int Quantity { get; set; }


        public bool Confirmed { get; set; }


        public decimal Value { get; set; }
    }

}
