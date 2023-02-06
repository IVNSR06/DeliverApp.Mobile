using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(ViewModels.ProfilePageViewModel));
        }
    }
}

