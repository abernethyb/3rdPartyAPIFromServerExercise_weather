using Microsoft.Extensions.Configuration;
using FullStackSimpleWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace FullStackSimpleWeatherApp.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        

        public async Task<WeatherResponse> FetchWeather(string sZip)
        {
            Key key = new Key();

            var uri = $"https://api.openweathermap.org/data/2.5/weather?zip={sZip},us&units=imperial&appid={key.name}";
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync(uri);

            var json = await response.Content.ReadAsStreamAsync();
            var weatherData = await JsonSerializer.DeserializeAsync<WeatherResponse>(json);

            return weatherData;

        }
    }
}
