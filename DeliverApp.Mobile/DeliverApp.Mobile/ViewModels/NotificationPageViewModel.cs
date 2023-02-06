using System;
using DeliverApp.Mobile.Services;

namespace DeliverApp.Mobile.ViewModels
{
	public class NotificationPageViewModel : BaseViewModel
	{
		public NotificationPageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

