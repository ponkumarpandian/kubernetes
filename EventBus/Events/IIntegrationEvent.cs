using EventBus.Events;

namespace BuildingBlocks.EventBus
{
    public interface IIntegrationEvent<T> where T : IntegrationEvent
    {
    }
}