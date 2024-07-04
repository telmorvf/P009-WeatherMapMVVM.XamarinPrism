using System.Globalization;
using WeatherMapMVVM.Interfaces;
using WeatherMapMVVM.Resources;
using Xamarin.Forms;

namespace WeatherMapMVVM.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept => Resource.Accept;

        public static string City => Resource.City;

        public static string CityForecast => Resource.CityForecast;

        public static string Culture { get; set; }

        public static string ConnectionError => Resource.ConnectionError;

        public static string Error => Resource.Error;

        public static string GlobalIdLocal => Resource.GlobalIdLocal;

        public static string IsRunning => Resource.IsRunning;

        public static string Loading => Resource.Loading;

        public static string Login => Resource.Login;

        public static string MinTemp => Resource.TMin;

        public static string MaxTemp => Resource.TMax;

        public static string Name => Resource.Name;

        public static string Weather => Resource.Weather;

        public static string WeatherForecast => Resource.WeatherForecast;

        public static string PredWindDir => Resource.PredWindDir;

        public static string PrecipitaProb => Resource.PrecipitaProb;

        public static string SearchCity => Resource.SearchCity;

        public static string ListForecast => Resource.ListForecast;

        public static string Country => Resource.Country;

        public static string ViewUser => Resource.ViewUser;

        public static string About => Resource.About;

        public static string Author => Resource.Author;

        public static string Date => Resource.Date;

        public static string Version => Resource.Version;
    }
}