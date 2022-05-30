using Microsoft.EntityFrameworkCore;
using TimesheetManagement.Domain.Entities.Timesheet;

namespace TimesheetManagement.Services.Interfaces.DbContext
{
    public interface ITimesheetManagementContext
    {
        public DbSet<TimesheetDay>? TimesheetDays { get; set; }
        public DbSet<TimesheetTime>? TimesheetTimes { get; set; }

        Task<int> SaveChanges();
    }
}
