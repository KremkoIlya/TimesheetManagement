using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimesheetManagement.API.Models.TimesheetDay;
using TimesheetManagement.Services.Timesheet.Interfaces;

namespace TimesheetManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimesheetDayController : ControllerBase
    {
        protected ITimesheetDayService _timesheetDayService;

        public TimesheetDayController(ITimesheetDayService timesheetDayService)
        {
            _timesheetDayService = timesheetDayService;
        }

        [HttpPost]
        public async void Post([FromBody]TimesheetDayVM model)
        {
            //TODO: Add mappings from VM to DM and from DM to entities
            //Organize the responses(models) from our API
            //Organize validating
            //Organize error handling
            //Organize exception handling
            await _timesheetDayService.Add(new Domain.Entities.Timesheet.TimesheetDay { Date = model.Date, DayType = (Domain.Entities.Timesheet.DayType)model.DayType });
        }
    }
}
