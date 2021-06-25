using System;

using Microsoft.Extensions.Logging;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultLogging(this IServiceCollection services, LogLevel logLevel = LogLevel.Debug)
        {
            services
                .AddLogging(loggingBuilder =>
                {
                    loggingBuilder
                        .AddConsole(consoleLoggerOptions =>
                        {
                            // Do nothing.
                        })
                        .SetMinimumLevel(logLevel);
                        ;
                })
                ;

            return services;
        }
    }
}
