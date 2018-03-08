using System;

namespace Common.IntegrationModel
{

    public class Order
    {
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    }
}


