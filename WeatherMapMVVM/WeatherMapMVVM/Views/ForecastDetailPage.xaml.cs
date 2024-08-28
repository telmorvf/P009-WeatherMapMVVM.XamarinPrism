using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WeatherMapMVVM.Views
{
    public partial class ForecastDetailPage : ContentPage
    {
        public ForecastDetailPage()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            //var latlng = new Position(38.85, -8.9);
            //myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(150)));

            //string lat = "";
            //string longi = "";
            //await WaitAndExecute(1000, () => lat = latitude.Text, () => longi = longitude.Text);

            //LoadMap(lat, longi);

            string lat = latitude.Text;
            string longi = longitude.Text;
            try
            {
                var latlng = new Position(double.Parse(lat), double.Parse(longi));
                //var latlng = new Position(38.85, -8.9);

                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(4000)));

                await WaitAndExecute(1100, () => lat = latitude.Text, () => longi = longitude.Text);

                LoadMap(lat, longi);
            }
            catch (Exception)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"latitude: ''{lat}'' longitude: ''{longi}''", "Accept");
                return;
            }



        }

        protected async Task WaitAndExecute(int milisec, Action actionToExecute, Action actionToExecute2) 
            { await Task.Delay(milisec); actionToExecute(); actionToExecute2(); }

        private void LoadMap(string lat, string longi)
        {
            if (string.IsNullOrEmpty(lat) || string.IsNullOrEmpty(longi))
            {
                var latlng = new Position(38.85, -8.9);
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(200)));
            }
            else
            {
                var latlng = new Position(Convert.ToDouble(lat), Convert.ToDouble(longi));
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(40)));
            }
        }

    }
}
