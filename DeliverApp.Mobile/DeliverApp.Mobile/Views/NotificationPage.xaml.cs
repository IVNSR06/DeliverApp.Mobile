using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(ViewModels.NotificationPageViewModel));
        }
    }
}

