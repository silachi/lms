using System;
using System.Collections.Generic;

namespace WebApplication2
{
    public class WeatherData : IWeatherData
    {
        private List<WeatherForecast> weatherStats = new List<WeatherForecast>
        {
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Warm" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Chilly" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Scorching" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Sweltering" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Balmy" }
        };

        public List<WeatherForecast> GetWeatherData() {
            return weatherStats;
        }
    }
}
