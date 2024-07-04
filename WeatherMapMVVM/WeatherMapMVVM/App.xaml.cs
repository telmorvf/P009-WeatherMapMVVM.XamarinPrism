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
            SyncfusionLicenseProvider.RegisterLicense("ODEyMjk4QDMyMzAyZTM0MmUzMGVDYU8ycFpyMlV0K1o5QmVaVDVEUGxDN2pMNDM3dEJZRlZaeVk4SVNPRWs9\r\n");
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/ForecastPage");

            await NavigationService.NavigateAsync($"/{nameof(ForecastMasterDetailPage)}/NavigationPage/{nameof(ForecastPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<ForecastPage, ForecastPageViewModel>();
            containerRegistry.RegisterForNavigation<ForecastDetailPage, ForecastDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<ForecastMasterDetailPage, ForecastMasterDetailPageViewModel>();
        }
    }
}
