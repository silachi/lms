using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace WebApplication2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        List<WeatherForecast> weatherForecastList = new List<WeatherForecast>
        {
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Warm" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Chilly" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Scorching" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Sweltering" },
            new WeatherForecast {Date=DateTime.Now, TemperatureC=-4, Summary="Balmy" }
        };

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[action]")]
        public List<WeatherForecast> Get()
        {
            return weatherForecastList;
        }
        [Route("weather")]
        [HttpPost]
        public List<WeatherForecast> AddWeather([FromBody] WeatherForecast weatherInput)
        {
            weatherForecastList.Add(weatherInput);
            return weatherForecastList;
        }
        [Route("weather/{weatherUpdateIndex}")]
        [HttpPut]
        public List<WeatherForecast> UpdateWeather(int weatherUpdateIndex, [FromBody] WeatherForecast weatherUpdateInput)
        {
            weatherForecastList[weatherUpdateIndex - 1].Date = DateTime.Now;
            weatherForecastList[weatherUpdateIndex - 1].TemperatureC = weatherUpdateInput.TemperatureC;
            weatherForecastList[weatherUpdateIndex - 1].Summary = weatherUpdateInput.Summary;
            return weatherForecastList;
        }
        [Route("weather/{weatherDeleteIndex}")]
        [HttpDelete]
        public List<WeatherForecast> DeleteWeather(int weatherDeleteIndex)
        {
            weatherForecastList.Remove(weatherForecastList[weatherDeleteIndex - 1]);
            return weatherForecastList;
        }
    }
}
