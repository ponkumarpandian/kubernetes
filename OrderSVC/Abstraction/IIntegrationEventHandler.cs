using OrderSVC.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSVC.Abstraction
{
    public interface IIntegrationEventHandler<in TIntegrationEvent>: IIntegrationEventHandler
         where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
