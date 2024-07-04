using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherMapMVVM.Models;

namespace WeatherMapMVVM.ItemViewModels
{
    public class ForecastItemViewModel : CityForecastResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectCityForecastCommand;

        public ForecastItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //public DelegateCommand SelectCityForecastCommand =>
        //    _selectCityForecastCommand ??
        //    (_selectCityForecastCommand = new DelegateCommand(SelectCityForecastAsync));

        //private async void SelectCityForecastAsync()
        //{
        //    NavigationParameters parameters = new NavigationParameters
        //    {
        //        { "product", this}
        //    };
        //    await _navigationService.NavigateAsync(nameof(CityForecastDetailPage), parameters);
        //}
    }
}
