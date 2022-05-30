using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetManagement.Domain.Entities.Timesheet
{
    public class TimesheetDay : BaseEntity
    {
        public TimesheetDay()
        {
            TimesheetTimes = new List<TimesheetTime>();
        }

        public DayType DayType { get; set; }

        public IEnumerable<TimesheetTime> TimesheetTimes { get; set; }
    }

    public enum DayType
    {
        WorkingDay,
        DayOff
    }
}
