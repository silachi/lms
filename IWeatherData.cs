using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public interface IWeatherData
    {
        public List<WeatherForecast> GetWeatherData();
    }
}
