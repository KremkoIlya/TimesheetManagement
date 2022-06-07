using TimesheetManagement.Contracts.Timesheet;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.General;

namespace TimesheetManagement.Services.Timesheet.Implementations
{
    public class TimesheetDayService : BaseService<TimesheetDay>, ITimesheetDayService
    {
        public TimesheetDayService()
        { }
    }
}
