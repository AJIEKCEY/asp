using System;
using System.Collections.Generic;

namespace MetricsManager
{
    public class WeatherHolder
    {
        public List<WeatherForecast> WhetherStatistics { get; set; }

        public WeatherHolder()
        {
            WhetherStatistics = new List<WeatherForecast>(16);
        }
    }
}