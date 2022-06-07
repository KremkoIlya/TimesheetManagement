using NLog;
using TimesheetManagement.Contracts.Logging;

namespace TimesheetManagement.Utils.Logging
{
    public class LoggerService : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void Error(string message)
        {
            logger.Error(message);
        }
    }
}
