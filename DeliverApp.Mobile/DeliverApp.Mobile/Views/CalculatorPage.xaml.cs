using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeliverApp.Mobile.Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(ViewModels.CalculatorPageViewModel));
        }
    }
}

