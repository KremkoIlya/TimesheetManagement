using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Day type is a required field.")]
        public DayType DayType { get; set; }

        [Required(ErrorMessage = "Date is a required field.")]
        public DateTime Date { get; set; }

        public ICollection<TimesheetPeriod> TimesheetPeriods { get; set; }
    }

    public enum DayType
    {
        WorkingDay,
        DayOff
    }
}
