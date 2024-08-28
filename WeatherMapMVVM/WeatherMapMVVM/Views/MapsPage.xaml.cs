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
            string lat = "38.758" ;
            string longi = "-9.1455";
            
            LoadMap(lat, longi, 6000);
            await WaitAndExecute(1500, () => lat = "38.758", () => longi = "-9.1455");
            LoadMap(lat, longi, 8);
        }

        protected async Task WaitAndExecute(int milisec, Action actionToExecute, Action actionToExecute2) 
            { await Task.Delay(milisec); actionToExecute(); actionToExecute2(); }

        private void LoadMap(string lat, string longi, int km)
        {
            var latlng = new Position(double.Parse(lat), double.Parse(longi));
            myGoogleMaps.MoveToRegion(MapSpan.FromCenterAndRadius(latlng, Distance.FromKilometers(km)));
        }
    }
}
