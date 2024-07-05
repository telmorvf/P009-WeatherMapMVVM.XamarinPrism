using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherMapMVVM.Helpers;

namespace WeatherMapMVVM.ViewModels
{
    public class ExitPageViewModel : ViewModelBase
    {
        public ExitPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.About;


        }
    }
}
