using System;
using System.Collections.Generic;

namespace GCloud.GraphQL
{
    public class WeatherForecastV2
    {
        public String Version { get; set; }
        public List<WeatherForecast> WeatherForecasts { get; set; }
    }
}
