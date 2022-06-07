using TimesheetManagement.Contracts.Timesheet;
using TimesheetManagement.Data.Contexts;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.General;

namespace TimesheetManagement.Services.Timesheet.Implementations
{
    public class TimesheetPeriodService : BaseService<TimesheetPeriod>, ITimesheetPeriodService
    {
        public TimesheetPeriodService(TimesheetManagementContext context) : base(context)
        { }
    }
}
