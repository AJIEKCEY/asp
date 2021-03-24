using System;
using MetricsManager.Enums; 
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class AgentController : Controller
    {
        [HttpGet("cpu/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetCpuMetricsByPercentile([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] Percentile percentile)
        {
            return Ok();
        }
        
        [HttpGet("cpu/from/{fromTime}/to/{toTime}")]
        public IActionResult GetCpuMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        
        [HttpGet("dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetDotNetErrorsCount([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        
        [HttpGet("network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetNetworkMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        
        [HttpGet("hdd/left")]
        public IActionResult GetHddLeftSpace()
        {
            return Ok();
        }
        
        [HttpGet("ram/available")]
        public IActionResult GetRamAvailable()
        {
            return Ok();
        }
    }
}