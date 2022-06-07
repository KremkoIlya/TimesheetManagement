using System;
using System.Collections.Generic;
using System.Text;

namespace TimesheetManagement.Contracts.Logging
{
    public interface ILoggerService
    {
        void Error(string message);
    }
}
