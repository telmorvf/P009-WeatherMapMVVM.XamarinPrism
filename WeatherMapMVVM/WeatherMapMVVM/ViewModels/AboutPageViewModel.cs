using Prism.Navigation;
using WeatherMapMVVM.Helpers;

namespace WeatherMapMVVM.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.About;
        }
    }
}