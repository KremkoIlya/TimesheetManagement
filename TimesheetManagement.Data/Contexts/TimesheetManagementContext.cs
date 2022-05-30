using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetManagement.Data.Contexts
{
    public class TimesheetManagementContext : DbContext
    {
        public TimesheetManagementContext(DbContextOptions options) : base(options) { }
    }
}
