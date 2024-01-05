using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NetCoreWebApiKafka.Application.Interfaces;
using System.Threading.Tasks;

namespace NetCoreWebApiKafka.Infrastructure.Shared.Services
{
    public class KafKaProducerService : IProducerService
    {
        private readonly IConfiguration _configuration;
        private readonly IProducer<Null, string> _producer;
        private readonly ILogger<KafkaConsumerService> _logger;

        // KafKa configuration
        private readonly string _bootstrapServers;

        public KafKaProducerService(IConfiguration configuration, ILogger<KafkaConsumerService> logger)
        {
            _configuration = configuration;
            _logger = logger;

            _bootstrapServers = configuration["Kafka:BootstrapServers"];

            var producerconfig = new ProducerConfig
            {
                BootstrapServers = _bootstrapServers
            };
            _producer = new ProducerBuilder<Null, string>(producerconfig).Build();
        }

        public async Task ProduceAsync(string topic, string message)
        {
            var kafkaMessage = new Message<Null, string> { Value = message };
            try
            {
                var result = await _producer.ProduceAsync(topic, kafkaMessage);
                _logger.LogInformation($"Message sent to {result.TopicPartitionOffset}");
            }
            catch (ProduceException<Null, string> e)
            {
                _logger.LogError($"Failed to deliver message: {e.Message} [{e.Error.Code}]");
                // Optionally, implement retry logic here
            }
        }
    }
}
