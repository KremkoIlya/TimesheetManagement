using Microsoft.EntityFrameworkCore;
using TimesheetManagement.Domain.Entities.Timesheet;

namespace TimesheetManagement.Services.DbContext
{
    public interface ITimesheetManagementContext
    {
        public DbSet<TimesheetDay> TimesheetDays { get; set; }
        public DbSet<TimesheetPeriod> TimesheetPeriods { get; set; }

        Task<int> SaveChanges();

    }
}
