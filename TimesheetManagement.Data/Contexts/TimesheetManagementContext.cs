using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Domain.Entities.Timesheet;
using TimesheetManagement.Services.DbContext;

namespace TimesheetManagement.Data.Contexts
{
    public class TimesheetManagementContext : DbContext, ITimesheetManagementContext
    {
        public DbSet<TimesheetDay> TimesheetDays { get; set; }
        public DbSet<TimesheetPeriod> TimesheetPeriods { get; set; }

        public TimesheetManagementContext(DbContextOptions options) : base(options) { }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
