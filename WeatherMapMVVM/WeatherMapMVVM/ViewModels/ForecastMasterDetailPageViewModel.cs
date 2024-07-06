using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WeatherMapMVVM.Helpers;
using WeatherMapMVVM.ItemViewModels;
using WeatherMapMVVM.Models;
using WeatherMapMVVM.Views;

namespace WeatherMapMVVM.ViewModels
{
    public class ForecastMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ForecastMasterDetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_forecast",
                    PageName = $"{nameof(ForecastPage)}",
                    Title = Languages.WeatherForecast
                },
                new Menu
                {
                    Icon = "ic_cardinal_points",
                    PageName = $"{nameof(CardinalPointsPage)}",
                    Title = Languages.CardinalPoints
                },
                new Menu
                {
                    Icon = "ic_google_maps",
                    PageName = $"{nameof(MapsPage)}",
                    Title = "Google Maps"
                },
                new Menu
                {
                    Icon = "ic_at1",
                    PageName = $"{nameof(AboutPage)}",
                    Title = Languages.About
                },
                new Menu
                {
                    Icon = "ic_exit1",
                    PageName = $"{nameof(ExitPage)}",
                    Title = Title = Languages.Exit
                }
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title,
                    IsLoginRequired = m.IsLoginRequired
                }).ToList());
        }
    }
}