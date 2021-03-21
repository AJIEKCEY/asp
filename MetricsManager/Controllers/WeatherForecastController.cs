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
       
        private readonly WeatherHolder holder;

        public WeatherForecastController(WeatherHolder holder)
        {
            this.holder = holder;
        }
        
        
        [HttpPost("create")]
        public IActionResult Create([FromQuery] string date, string temperatureC)
        {
            holder.WhetherStatistics.Add(new WeatherForecast
            {
                Date = DateTime.Parse(date),
                TemperatureC = Int32.Parse(temperatureC)
            });
            return Ok();
        }
        
        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok(holder.WhetherStatistics);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] string date, string newTemperatureValue)
        {
            DateTime dateTime = DateTime.Parse(date);
            int newValue = Int32.Parse(newTemperatureValue);
            
            foreach (WeatherForecast item in holder.WhetherStatistics)
            {
                if (item.Date == dateTime)
                    item.TemperatureC = newValue;
            }

            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string dateFrom, string dateTo)
        {
            DateTime deleteFromDate = DateTime.Parse(dateFrom);
            DateTime deleteByDate = DateTime.Parse(dateTo);
            
            holder.WhetherStatistics = holder.WhetherStatistics.Where(w => w.Date < deleteFromDate && w.Date > deleteByDate).ToList();
            return Ok();
        }
    }
}
