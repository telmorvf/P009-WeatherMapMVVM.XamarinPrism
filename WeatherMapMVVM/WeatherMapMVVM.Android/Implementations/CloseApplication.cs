using Android.App;
using WeatherMapMVVM.Services;
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