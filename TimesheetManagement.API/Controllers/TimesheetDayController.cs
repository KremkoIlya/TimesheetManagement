using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimesheetManagement.API.Models.TimesheetDay;

namespace TimesheetManagement.API.Controllers
{
    [ApiController]
    [Route("api/timesheetdays")]
    public class TimesheetDayController : ControllerBase
    {
        public TimesheetDayController()
        { }
    }
}
