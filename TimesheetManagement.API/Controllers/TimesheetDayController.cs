using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimesheetManagement.API.Models.TimesheetDay;
using TimesheetManagement.Contracts.Timesheet;

namespace TimesheetManagement.API.Controllers
{
    [ApiController]
    [Route("api/timesheetdays")]
    public class TimesheetDayController : ControllerBase
    {
        protected ITimesheetDayService _timesheetDayService;

        public TimesheetDayController(ITimesheetDayService timesheetDayService)
        {
            _timesheetDayService = timesheetDayService;
        }

        [HttpPost]
        public async Task Post([FromBody]TimesheetDayVM model)
        {
            //TODO: Add mappings from VM to DM and from DM to entities
            //Organize the responses(models) from our API
            //Organize validating
            //Organize error handling
            //Organize exception handling
            _timesheetDayService.Create(new Domain.Entities.Timesheet.TimesheetDay 
            {
                Date = model.Date,
                DayType = (Domain.Entities.Timesheet.DayType)model.DayType,
            });
            await _timesheetDayService.SaveChangesAsync();
        }
    }
}
