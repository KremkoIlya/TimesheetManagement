using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetManagement.Domain.Entities.Timesheet
{
    public class TimesheetPeriod : BaseEntity
    {
        [Required(ErrorMessage = "Start time is a required field.")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End time is a required field.")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Is Available is a required field.")]
        public bool IsAvailable { get; set; }

        public int TimesheetDayId { get; set; }
        public TimesheetDay? TimesheetDay { get; set; }
    }
}
