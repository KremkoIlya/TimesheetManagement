using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using TimesheetManagement.Services.Logging;

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
