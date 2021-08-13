using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherForCity(string city);
    }
}
