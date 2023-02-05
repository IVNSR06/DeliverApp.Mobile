using System;
using System.Threading.Tasks;
using DeliverApp.Mobile.ViewModels;

namespace DeliverApp.Mobile.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
    }
}

