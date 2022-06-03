using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.DbContext;
using TimesheetManagement.Services.General;
using TimesheetManagement.Services.Timesheet.Interfaces;

namespace TimesheetManagement.Services.Timesheet.Implementations
{
    public class TimesheetDayService : BaseService<TimesheetDay>, ITimesheetDayService
    {
        public TimesheetDayService(ITimesheetManagementContext context) : base(context)
        { }

        public Task<int> Add(TimesheetDay day)
        {
            Context.TimesheetDays.AddAsync(day);
            return Context.SaveChanges();
        }
    }
}
