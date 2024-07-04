using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherMapMVVM.Models
{
    public class WeatherData
    {
        [JsonProperty("precipitaProb")]
        public string PrecipitaProb { get; set; }

        [JsonProperty("tMin")]
        public int TMin { get; set; }

        [JsonProperty("tMax")]
        public int TMax { get; set; }

        [JsonProperty("predWindDir")]
        public string PredWindDir { get; set; }

        [JsonProperty("idWeatherType")]
        public int IdWeatherType { get; set; }

        [JsonProperty("classWindSpeed")]
        public int ClassWindSpeed { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("classPrecInt")]
        public int ClassPrecInt { get; set; }

        [JsonProperty("globalIdLocal")]
        public int GlobalIdLocal { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
