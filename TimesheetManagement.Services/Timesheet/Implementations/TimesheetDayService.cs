using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.DbContext;
using TimesheetManagement.Services.Timesheet.Interfaces;

namespace TimesheetManagement.Services.Timesheet.Implementations
{
    public class TimesheetDayService : ITimesheetDayService
    {
        public ITimesheetManagementContext Context { get; set; }

        public TimesheetDayService(ITimesheetManagementContext context)
        {
            Context = context;
        }

        public Task Add(TimesheetDay day)
        {
            return Context.TimesheetDays.AddAsync(day).AsTask();
        }
    }
}
