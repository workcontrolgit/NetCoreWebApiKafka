using System.Threading.Tasks;

namespace NetCoreWebApiKafka.Application.Interfaces
{
    public interface IProducerService
    {
        Task ProduceAsync(string topic, string message);
    }
}