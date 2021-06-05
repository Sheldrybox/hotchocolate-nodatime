using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolate.Types.NodaTime.Extensions
{
    public static class IRequestExecutionBuilderExtensions
    {
        public static IRequestExecutorBuilder AddNodaTime(this IRequestExecutorBuilder requestBuilder)
        {
            return requestBuilder
                .AddType<DateTimeZoneType>()
                .AddType<DurationType>()
                .AddType<InstantType>()
                .AddType<IsoDayOfWeekType>()
                .AddType<LocalDateTimeType>()
                .AddType<LocalDateType>()
                .AddType<LocalTimeType>()
                .AddType<OffsetDateTimeType>()
                .AddType<OffsetDateType>()
                .AddType<OffsetTimeType>()
                .AddType<OffsetType>()
                .AddType<PeriodType>()
                .AddType<ZonedDateTimeType>();
        }
    }
}
