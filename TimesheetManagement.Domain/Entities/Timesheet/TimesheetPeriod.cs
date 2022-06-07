using System;
using System.ComponentModel.DataAnnotations;

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
