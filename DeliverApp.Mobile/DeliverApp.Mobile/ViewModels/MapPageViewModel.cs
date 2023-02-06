using System;
using DeliverApp.Mobile.Services;

namespace DeliverApp.Mobile.ViewModels
{
	public class MapPageViewModel : BaseViewModel
	{
		public MapPageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

