using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetManagement.Domain.Entities.Timesheet
{
    public class TimesheetTime : BaseEntity
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsAvailable { get; set; }

        public int TimesheetDayId { get; set; }
        public TimesheetDay? TimesheetDay { get; set; }
    }
}
