using EventBus.Events;
using PaymentSVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.Events
{
    public class OrderConfirmationIntegrationEvent : IntegrationEvent
    {


        public order _orderinfo { get; set; }

        public OrderConfirmationIntegrationEvent(order orderinfo )
        {
            _orderinfo = orderinfo;
        }
    }
}
