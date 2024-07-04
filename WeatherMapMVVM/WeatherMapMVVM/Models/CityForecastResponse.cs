using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherMapMVVM.Models
{
    public class CityForecastResponse
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("forecastDate")]
        public string ForecastDate { get; set; }

        [JsonProperty("data")]
        public List<WeatherData> Data { get; set; }

        [JsonProperty("dataUpdate")]
        public string DataUpdate { get; set; }
    }
}
