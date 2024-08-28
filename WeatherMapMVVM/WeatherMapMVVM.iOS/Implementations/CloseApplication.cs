using System.Threading;
using WeatherMapMVVM.Interfaces;

namespace WeatherMapMVVM.iOS.Implementations
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}