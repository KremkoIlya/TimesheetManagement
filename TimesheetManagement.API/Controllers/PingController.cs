using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TimesheetManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public string Ping()
        {
            return "pong";
        }

        [Authorize]
        [HttpGet("auth")]
        public string PingAuth()
        {
            return "auth pong";
        }
    }
}
