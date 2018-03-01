
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.EventBusRabbitMQ
{
    public interface IRabbitMQPersistentConnection
       : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        RabbitMQ.Client.IModel CreateModel();
    }
}
