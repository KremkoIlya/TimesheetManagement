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
    public class TimesheetPeriodService : ITimesheetPeriodService
    {
        public ITimesheetManagementContext Context { get; set; }

        public TimesheetPeriodService(ITimesheetManagementContext context)
        {
            Context = context;
        }

        public Task<int> Add(TimesheetPeriod period)
        {
            Context.TimesheetPeriods.AddAsync(period);
            return Context.SaveChanges();
        }
    }
}
