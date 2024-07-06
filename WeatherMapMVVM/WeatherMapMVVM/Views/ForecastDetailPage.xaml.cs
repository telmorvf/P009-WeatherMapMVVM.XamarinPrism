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
            var latlng = new Position(38.85, -8.9);
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(150)));

            string lat = "";
            string longi = "";
            await WaitAndExecute(1000, () => lat = latitude.Text, () => longi = longitude.Text);

            LoadMap(lat, longi);
        }

        protected async Task WaitAndExecute(int milisec, Action actionToExecute, Action actionToExecute2) 
            { await Task.Delay(milisec); actionToExecute(); actionToExecute2(); }

        private void LoadMap(string lat, string longi)
        {
            if (string.IsNullOrEmpty(lat) || string.IsNullOrEmpty(longi))
            {
                var latlng = new Position(38.85, -8.9);
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(60)));
            }
            else
            {
                var latlng = new Position(Convert.ToDouble(lat), Convert.ToDouble(longi));
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(60)));
            }
        }

    }
}
