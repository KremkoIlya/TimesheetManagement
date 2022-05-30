using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Domain.Entities.Timesheet;

namespace TimesheetManagement.Data.Contexts
{
    public class TimesheetManagementContext : DbContext
    {
        public DbSet<TimesheetDay> TimesheetDays { get; set; }
        public DbSet<TimesheetTime> TimesheetTimes { get; set; }

        public TimesheetManagementContext(DbContextOptions options) : base(options) { }
    }
}
