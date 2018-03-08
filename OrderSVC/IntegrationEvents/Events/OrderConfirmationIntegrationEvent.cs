using EventBus.Events;
using OrderSVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.IntegrationModel;

namespace OrderSVC.Events
{
    public class OrderConfirmationIntegrationEvent : IntegrationEvent
    {


        public Order _order { get; set; }

        public OrderConfirmationIntegrationEvent(Order  order )
        {
            _order = order;
        }
    }
}
