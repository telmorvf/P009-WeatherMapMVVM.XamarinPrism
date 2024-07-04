using Prism.Commands;
using Prism.Navigation;
using WeatherMapMVVM.Models;
using WeatherMapMVVM.Views;

namespace WeatherMapMVVM.ItemViewModels
{
    public class CityItemViewModel : CityForecast
    {

        private readonly INavigationService _navigationService;
        private DelegateCommand _selectCityCommand;

        public CityItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectCityCommand =>
            _selectCityCommand ?? (_selectCityCommand = new DelegateCommand(SelectCityAsync));

        private async void SelectCityAsync()
        {
            NavigationParameters parameters = new NavigationParameters
            {
                {"city",this }
            };
            await _navigationService.NavigateAsync(nameof(ForecastDetailPage), parameters);
        }
    }
}
