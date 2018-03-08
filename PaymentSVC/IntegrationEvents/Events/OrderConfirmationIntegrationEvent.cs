using Common.IntegrationModel;
using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.Events
{
    public class OrderConfirmationIntegrationEvent : IntegrationEvent
    {


        public Order _orderinfo { get; set; }

        public OrderConfirmationIntegrationEvent(Order orderinfo )
        {
            _orderinfo = orderinfo;
        }
    }
}
