using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FullStackSimpleWeatherApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackSimpleWeatherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        ///api/layer/88
        [HttpGet("{sZip}")]
        public async Task<IActionResult> Get(string sZip)
        {
            var weatherResponse = await _weatherRepository.FetchWeather(sZip);
            return Ok(weatherResponse);


        }
    }
}
