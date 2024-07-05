using Example;
using Prism.Commands;
using Prism.Navigation;
using WeatherMapMVVM.Services;
using WeatherMapMVVM.Views;

namespace WeatherMapMVVM.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private string _password;
        private bool _isRunning;
        private bool _isEnable;
        private DelegateCommand _loginCommand;

        public LoginPageViewModel(
            INavigationService navigationService,
            IApiService apiService
            ) : base(navigationService)
        {
            Title = "Login";
            IsEnable = true;
            _navigationService = navigationService;
            _apiService = apiService;
        }

        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));

        public string Email { get; set; }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }

        public bool IsEnable
        {
            get => _isEnable;
            set => SetProperty(ref _isEnable, value);
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter an Email.", "Accept");
                Password = string.Empty;
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a Password.", "Accept");
                Password = string.Empty;
                return;
            }

            IsRunning = true;
            var response = await _apiService.ApiLoginAsync(Email, Password);
            IsRunning = false;
            if (response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Success", $"Welcome {response.Message}", "Continue");
                Password = string.Empty;

                await _navigationService.NavigateAsync($"/{nameof(ForecastMasterDetailPage)}/NavigationPage/ForecastPage"); ;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Incorrect password", "Accept");
                Password = string.Empty;
            }


            //await App.Current.MainPage.DisplayAlert("OK", "Boa, Entrámos", "Accept");
        }


    }
}

