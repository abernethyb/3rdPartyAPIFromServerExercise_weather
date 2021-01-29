using FullStackSimpleWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackSimpleWeatherApp.Repositories
{
    public interface IWeatherRepository
    {
        Task<WeatherResponse> FetchWeather(string sZip);
    }
}
