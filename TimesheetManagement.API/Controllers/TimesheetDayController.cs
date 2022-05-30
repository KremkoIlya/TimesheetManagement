using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TimesheetManagement.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class TimesheetDayController : ControllerBase
    {
        public TimesheetDayController()
        {

        }
    }
}
