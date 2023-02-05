using System;
using DeliverApp.Mobile.Services;

namespace DeliverApp.Mobile.ViewModels
{
	public class LoginPageViewModel : BaseViewModel
	{
		public LoginPageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

