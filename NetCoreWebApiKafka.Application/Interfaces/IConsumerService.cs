
using Microsoft.Extensions.Hosting;
using System.Threading;

namespace NetCoreWebApiKafka.Application.Interfaces
{
    public interface IConsumerService : IHostedService
    {
        void ProcessKafkaMessage(CancellationToken stoppingToken);
    }
}