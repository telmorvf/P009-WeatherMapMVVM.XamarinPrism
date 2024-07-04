using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherMapMVVM.Models
{
    public class CityForecast
    {
        public string Owner { get; set; }
        public string Country { get; set; }
        public string ForecastDate { get; set; }
        public string DataUpdate { get; set; }


        public string PrecipitaProb { get; set; }
        public int TMin { get; set; }
        public int TMax { get; set; }
        public string PredWindDir { get; set; }
        public int IdWeatherType { get; set; }
        public int ClassWindSpeed { get; set; }
        public double Longitude { get; set; }
        public int ClassPrecInt { get; set; }
        public int GlobalIdLocal { get; set; }
        public double Latitude { get; set; }
    }
}

