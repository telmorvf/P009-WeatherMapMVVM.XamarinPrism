using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherMapMVVM.ViewModels
{
    public class MapsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public MapsPageViewModel(
            INavigationService navigationService
            ) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Google Maps";
        }
    }
}
