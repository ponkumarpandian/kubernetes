using BuildingBlocks.EventBus;
using PaymentSVC.DAL;
using PaymentSVC.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.IntegrationEvents.EventHandling
{
    public class NewOrderIntegrationEventHandler : IIntegrationEventHandler<NewOrderIntegrationEvent>
    {
        public async Task<int> Handle(NewOrderIntegrationEvent @event)
        {
            // Add new payment information to the database.



            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());

            // The method then can process the result in some way.  
            int leisureHours;
            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;

            return leisureHours;
            //using (PaymentDBContext context = new PaymentDBContext())
            //{

            //}
        }
    }
}
