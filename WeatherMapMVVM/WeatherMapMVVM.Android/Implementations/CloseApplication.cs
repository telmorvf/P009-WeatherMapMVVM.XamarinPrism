using Android.App;
using WeatherMapMVVM.Interfaces;
using Xamarin.Forms;

namespace WeatherMapMVVM.Droid.Implementations
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();
        }
    }
}