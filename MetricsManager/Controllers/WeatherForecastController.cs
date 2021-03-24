using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MetricsManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherHolder _holder;

        public WeatherForecastController(WeatherHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _holder.WhetherStatistics.Add(new WeatherForecast
            {
                Date = date,
                TemperatureC = temperatureC
            });
            return Ok();
        }
        
        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok(_holder.WhetherStatistics);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int newTemperatureValue)
        {
            foreach (WeatherForecast item in _holder.WhetherStatistics)
            {
                if (item.Date == date)
                    item.TemperatureC = newTemperatureValue;
            }
            
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            _holder.WhetherStatistics = _holder.WhetherStatistics.Where(w => w.Date < dateFrom && w.Date > dateTo).ToList();
            return Ok();
        }
    }
}
