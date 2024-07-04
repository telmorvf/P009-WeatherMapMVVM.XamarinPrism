using System.Globalization;
using WeatherMapMVVM.Interfaces;
using WeatherMapMVVM.Resources;
using Xamarin.Forms;

namespace WeatherMap.Helpers
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

        public static string Culture { get; set; }

        public static string ConnectionError => Resource.ConnectionError;

        public static string Error => Resource.Error;

        public static string Name => Resource.Name;

        public static string Loading => Resource.Loading;

        public static string Login => Resource.Login;


    }
}