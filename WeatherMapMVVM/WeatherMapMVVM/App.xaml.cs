using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using WeatherMapMVVM.Services;
using WeatherMapMVVM.ViewModels;
using WeatherMapMVVM.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace WeatherMapMVVM
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("NzgyMzg2QDMyMzAyZTMzMmUzMGcxOS9jN3EvL2IyVkpOOWRmT0RoUituUGJKaUd1NFI5aFFvbFZPUE5vWEU9");
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
            
            //await NavigationService.NavigateAsync
                //($"/{nameof(WeatherPageMasterDetailPage)}/NavigationPage/{nameof(CityForcastPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            
            containerRegistry.RegisterForNavigation<CityForcastPage, CityForcastPageViewModel>();
        }
    }
}
