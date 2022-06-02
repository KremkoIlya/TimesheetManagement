using System;
using System.Collections.Generic;
using System.Text;

namespace TimesheetManagement.Services.Logging
{
    public interface ILoggerService
    {
        void Error(string message);
    }
}
