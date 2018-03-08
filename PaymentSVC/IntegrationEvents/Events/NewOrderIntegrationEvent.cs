using Common.IntegrationModel;
using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.IntegrationEvents.Events
{
    public class NewOrderIntegrationEvent: IntegrationEvent
    {
        public Order Order { get; set; }

        public NewOrderIntegrationEvent(Order order)
        {
            Order = order;
        }
    }
}
