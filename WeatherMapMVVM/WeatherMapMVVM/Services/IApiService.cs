using System.Threading.Tasks;
using WeatherMapMVVM.Models;

namespace WeatherMapMVVM.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);

        Task<Response> ApiLoginAsync(string email, string password);

    }
}
