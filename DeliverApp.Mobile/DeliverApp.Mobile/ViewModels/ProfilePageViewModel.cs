using System;
using DeliverApp.Mobile.Services;

namespace DeliverApp.Mobile.ViewModels
{
	public class ProfilePageViewModel : BaseViewModel
	{
		public ProfilePageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

