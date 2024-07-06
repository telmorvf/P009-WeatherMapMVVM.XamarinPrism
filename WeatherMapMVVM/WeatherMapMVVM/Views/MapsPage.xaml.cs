using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WeatherMapMVVM.Views
{
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            string lat = "";
            string longi = "";
            var latlng = new Position(38.85, -8.9);
            myGoogleMaps.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(80)));

            await WaitAndExecute(1000, () => lat = "41.5", () => longi = "-12.5");

            LoadMap(lat, longi);
        }
        protected async Task WaitAndExecute(int milisec, Action actionToExecute, Action actionToExecute2) { await Task.Delay(milisec); actionToExecute(); actionToExecute2(); }

        private void LoadMap(string lat, string longi)
        {
            var latlng = new Position(38.85, -8.9);
            myGoogleMaps.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(40)));
        }
    }
}
