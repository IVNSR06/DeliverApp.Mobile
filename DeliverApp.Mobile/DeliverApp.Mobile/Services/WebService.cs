using System;
using DeliverApp.Mobile.Helpers;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace DeliverApp.Mobile.Services
{
    public class WebService : IWebService
    {
        public async Task<T> GetAsync<T>(string method)
        {
            return await Constants.BaseURL.AppendPathSegment(method).GetJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(object body, string method)
        {
            return await Constants.BaseURL.WithHeader("Content-Type", "application/json").AppendPathSegment(method).PostJsonAsync(body).ReceiveJson<T>();
        }
    }
}

