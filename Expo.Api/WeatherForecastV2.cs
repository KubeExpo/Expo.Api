using System;
using System.Collections.Generic;

namespace Expo.Api
{
    public class WeatherForecastV2
    {
        public String Version { get; set; }
        public List<WeatherForecast> WeatherForecasts { get; set; }
    }
}
