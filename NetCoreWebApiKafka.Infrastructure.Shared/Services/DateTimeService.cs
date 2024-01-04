using NetCoreWebApiKafka.Application.Interfaces;
using System;

namespace NetCoreWebApiKafka.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}