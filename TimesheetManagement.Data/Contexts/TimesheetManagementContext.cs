using Microsoft.EntityFrameworkCore;

namespace TimesheetManagement.Data.Contexts
{
    public class TimesheetManagementContext : DbContext
    {
        public TimesheetManagementContext(DbContextOptions options) : base(options) { }
    }
}
