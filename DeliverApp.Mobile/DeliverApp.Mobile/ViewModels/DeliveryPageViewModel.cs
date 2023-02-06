using System;
using DeliverApp.Mobile.Services;

namespace DeliverApp.Mobile.ViewModels
{
	public class DeliveryPageViewModel : BaseViewModel
	{
		public DeliveryPageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

