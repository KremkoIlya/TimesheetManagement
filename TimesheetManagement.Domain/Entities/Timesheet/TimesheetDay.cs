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
            TimesheetPeriods = new List<TimesheetPeriod>();
        }

        public DayType DayType { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<TimesheetPeriod> TimesheetPeriods { get; set; }
    }

    public enum DayType
    {
        WorkingDay,
        DayOff
    }
}
