using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FullStackSimpleWeatherApp.Models
{
    public class WeatherResponse 
    {
        [JsonPropertyName("main")]
        public Current current { get; set; }

        [JsonPropertyName("name")]
        public string placeName { get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> WeatherResponses { get; set; }
    }
}
