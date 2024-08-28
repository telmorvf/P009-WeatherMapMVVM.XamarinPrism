using ImTools;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using WeatherMapMVVM.Interfaces;
using WeatherMapMVVM.Resources;
using WeatherMapMVVM.Views;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExitPage))]
namespace WeatherMapMVVM.Views
{
    public partial class ExitPage : ContentPage, ICloseApplication
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;

        //static ExitPage()
        //{

        //    DependencyService.Get<ICloseApplication>();
        //}

        public ExitPage(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
            btnGoback.Clicked += btnGoback_Clicked;
            btnExit.Clicked += btnExit_Clicked;
            
        }

        private async void btnGoback_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ForecastMasterDetailPage());
            await _navigationService.NavigateAsync
                ($"/{nameof(ForecastMasterDetailPage)}/NavigationPage/{nameof(ForecastPage)}");
        }
        private void btnExit_Clicked(object sender, EventArgs e)
        {
            closeApplication();
        }

        public void closeApplication()
        {
            var closer = DependencyService.Get<ICloseApplication>();
            closer?.closeApplication();
        }
    }
}