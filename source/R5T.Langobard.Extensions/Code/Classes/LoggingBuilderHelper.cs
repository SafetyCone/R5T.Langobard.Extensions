using System;

using Microsoft.Extensions.Logging;


namespace R5T.Langobard
{
    public class LoggingBuilderHelper
    {
        #region Static

        /// <summary>
        /// Adds console logging.
        /// </summary>
        private static void AddDefaultLogging(ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConsole();
        }

        #endregion
    }
}
