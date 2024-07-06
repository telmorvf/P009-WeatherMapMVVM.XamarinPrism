using Prism.Navigation;
using WeatherMapMVVM.Helpers;
using WeatherMapMVVM.Models;
using WeatherMapMVVM.Services;
using WeatherMapMVVM.ViewModels;

namespace WeatherMapMVVM.ViewModels
{
    public class ForecastDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private CityForecast _city;

        public ForecastDetailPageViewModel(
            INavigationService navigationService,
            IApiService apiService
            ) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = Languages.WeatherForecast;
        }

        public CityForecast City
        {
            get => _city;
            set => SetProperty(ref _city, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("city"))
            {
                City = parameters.GetValue<CityForecast>("city");
                Title = City.Local.ToString();
            }
        }
    }
}
