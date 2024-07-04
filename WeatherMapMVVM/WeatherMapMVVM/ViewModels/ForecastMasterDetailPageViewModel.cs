using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WeatherMapMVVM.Helpers;
using WeatherMapMVVM.ItemViewModels;
using WeatherMapMVVM.Models;
using WeatherMapMVVM.ViewModels;
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
                    Icon = "ic_wb_sunny",
                    PageName = $"{nameof(ForecastPage)}",
                    Title = Languages.WeatherForecast
                },
                new Menu
                {
                    Icon = "ic_countries",
                    PageName = $"{nameof(AboutPage)}",
                    Title = "qqqqqqq"
                },
                new Menu
                {
                    Icon = "ic_videogame_asset",
                    PageName = $"{nameof(AboutPage)}",
                    Title = "rrrrrrr"
                },
                new Menu
                {
                    Icon = "ic_about",
                    PageName = $"{nameof(AboutPage)}",
                    Title = Languages.About
                },
                new Menu
                {
                    Icon = "ic_directions_run",
                    PageName = $"{nameof(AboutPage)}",
                    Title = "rrrrrrr EXIT"
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