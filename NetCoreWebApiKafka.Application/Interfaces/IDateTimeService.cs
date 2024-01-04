using System;

namespace NetCoreWebApiKafka.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}