using System;
using System.Collections.Generic;
using DeliverApp.Mobile.ViewModels;
using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(MapPageViewModel)); 
        }
    }
}

