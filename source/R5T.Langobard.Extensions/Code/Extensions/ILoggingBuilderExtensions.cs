using System;

using Microsoft.Extensions.Logging;


namespace R5T.Langobard
{
    public static class ILoggingBuilderExtensions
    {
        /// <summary>
        /// Adds console logging.
        /// </summary>
        public static ILoggingBuilder AddBasicLogging(this ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConsole();

            return loggingBuilder;
        }
    }
}
