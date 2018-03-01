using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.EventBus
{
    public interface IIntegrationEventHandler<in TIntegrationEvent>: IIntegrationEventHandler
         where TIntegrationEvent : IntegrationEvent
    {
        Task<int> Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
