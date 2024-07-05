using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherMapMVVM.Models;

namespace WeatherMapMVVM.Services
{
    public class ApiService : IApiService
    {
        public async Task<Response> GetListAsync<T>(
        string urlBase,
        string servicePrefix,
        string controller)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase),
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                CityForecastResponse list = JsonConvert.DeserializeObject<CityForecastResponse>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = list
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> ApiLoginAsync(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Please enter the email and password."
                };
            }


            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                HttpClient client = new HttpClient(clientHandler);

                //client.BaseAddress = new Uri("https://supershop2022.azurewebsites.net");

                //client.BaseAddress = new Uri("https://localhost:44313");  // Local give error: Network subsystem is down
                client.BaseAddress = new Uri("https://p007-supershopwebmvc5.azurewebsites.net");

                var response = await client.GetAsync($"/account/login1?email={email}&password={password}");
                

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                if (result != "false")
                {
                    return new Response
                    {
                        IsSuccess = true,
                        Message = result
                    };
                }

                return new Response
                {
                    IsSuccess = false,
                    Message = "Login failed"
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }


    }
}

