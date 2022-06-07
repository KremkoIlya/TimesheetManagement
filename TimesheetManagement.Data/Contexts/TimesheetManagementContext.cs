using Microsoft.EntityFrameworkCore;
using TimesheetManagement.Domain.Entities.Timesheet;

namespace TimesheetManagement.Data.Contexts
{
    public class TimesheetManagementContext : DbContext
    {
        public DbSet<TimesheetDay> TimesheetDays { get; set; }
        public DbSet<TimesheetPeriod> TimesheetPeriods { get; set; }

        public TimesheetManagementContext(DbContextOptions options) : base(options) { }
    }
}
