using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.General;

namespace TimesheetManagement.Services.Timesheet.Interfaces
{
    public interface ITimesheetPeriodService : IBaseService<TimesheetPeriod>
    {
        Task<int> Add(TimesheetPeriod day);
    }
}
