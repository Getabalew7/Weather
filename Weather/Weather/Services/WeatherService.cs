
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    class WeatherService : IWeatherService
    {
        private const string WeatherApiKey = "4b76d6f615ed5ee3c4a19c869b244816";
        private const string units = "metric";
        private const string CurrentWeatherApiEndpoint = "https://api.openweathermap.org/data/2.5/weather";
        public async Task<WeatherData> GetWeatherForCity(string city)
        {
           
            var cityWeatherUrl = $"{CurrentWeatherApiEndpoint}?q={city}&units={units}&APPID={WeatherApiKey}";

            var httpClient = new HttpClient();
            var weatherResponse = await httpClient.GetStringAsync(cityWeatherUrl).ConfigureAwait(false);
            Debug.WriteLine(weatherResponse);
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(weatherResponse);
            return weatherData;
           
        }
    }
}
