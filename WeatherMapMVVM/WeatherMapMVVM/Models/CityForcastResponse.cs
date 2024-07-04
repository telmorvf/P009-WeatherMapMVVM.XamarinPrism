namespace WeatherMapMVVM.Models
{
    public class CityForcastResponse
    {
        public object ForecastDate { get; set; }

        public string Country { get; set; }

        public float PrecipitaProb { get; set; }

        public int TMin { get; set; }

        public int TMax { get; set; }

        public string PredWindDir { get; set; }

        public int IdWeatherType { get; set; }

        public int ClassWindSpeed { get; set; }

        public float Longitude { get; set; }

        public int ClassPrecInt { get; set; }

        public string GlobalIdLocal { get; set; }

        public float Latitude { get; set; }
    }
}

