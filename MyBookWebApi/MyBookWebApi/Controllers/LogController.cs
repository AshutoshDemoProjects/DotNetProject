using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookWebApi.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private LogsService _service;
        public LogController(LogsService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult GetAllLog()
        {
            try
            {
                var allLogs = _service.GetAllLogs();
                return Ok(allLogs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
