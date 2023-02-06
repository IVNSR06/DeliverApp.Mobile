using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class DeliveryPage : ContentPage
    {
        public DeliveryPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(ViewModels.DeliveryPageViewModel));
        }
    }
}

