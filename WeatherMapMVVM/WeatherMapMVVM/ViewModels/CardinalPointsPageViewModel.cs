using Prism.Navigation;
using WeatherMapMVVM.Helpers;

namespace WeatherMapMVVM.ViewModels
{
    public class CardinalPointsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CardinalPointsPageViewModel(
            INavigationService navigationService
            ) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = Languages.CardinalPoints;
        }
    }
}
