using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSVC.Models
{
    public class order
    {
        public int orderId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public decimal rate { get; set; }
    }
}
