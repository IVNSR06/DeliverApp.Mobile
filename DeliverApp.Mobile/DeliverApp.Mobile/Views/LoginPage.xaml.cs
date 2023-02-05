using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(ViewModels.LoginPageViewModel));
        }
    }
}

