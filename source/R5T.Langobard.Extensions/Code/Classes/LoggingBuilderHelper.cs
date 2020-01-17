using System;

using Microsoft.Extensions.Logging;


namespace R5T.Langobard
{
    public class LoggingBuilderHelper
    {
        #region Static

        /// <summary>
        /// Adds default logging.
        /// Default logging includes:
        /// * Console logging.
        /// </summary>
        public static void AddDefaultLogging(ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConsole();
        }

        #endregion
    }
}
