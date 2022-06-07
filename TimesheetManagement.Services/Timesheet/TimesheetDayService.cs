using TimesheetManagement.Contracts.Timesheet;
using TimesheetManagement.Data.Contexts;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.General;

namespace TimesheetManagement.Services.Timesheet.Implementations
{
    public class TimesheetDayService : BaseService<TimesheetDay>, ITimesheetDayService
    {
        public TimesheetDayService(TimesheetManagementContext context) : base(context)
        { }
    }
}
