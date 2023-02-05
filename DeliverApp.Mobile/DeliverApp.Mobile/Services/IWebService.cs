using System;
using System.Threading.Tasks;

namespace DeliverApp.Mobile.Services
{
    public interface IWebService
    {
        Task<T> GetAsync<T>(string method);
        Task<T> PostAsync<T>(object body, string method);
    }
}