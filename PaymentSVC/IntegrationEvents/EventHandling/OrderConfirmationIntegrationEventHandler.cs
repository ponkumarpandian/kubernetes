using BuildingBlocks.EventBus;
using PaymentSVC.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.IntegrationEvents.EventHandling
{
    public class OrderConfirmationIntegrationEventHandler : IIntegrationEventHandler<OrderConfirmationIntegrationEvent>
    {
        public async Task<int> Handle(OrderConfirmationIntegrationEvent @event)
        {
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());

            // The method then can process the result in some way.  
            int leisureHours;
            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;

            return leisureHours;
        }
    }
}
