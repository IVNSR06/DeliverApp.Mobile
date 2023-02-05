using System;
using DeliverApp.Mobile.Services;
using DeliverApp.Mobile.ViewModels;
using DeliverApp.Mobile.Views;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeliverApp.Mobile
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public App ()
        {
            InitializeComponent();

            SetupServices();

            MainPage = new LoginPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

        private void SetupServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IWebService, WebService>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddTransient<LoginPageViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}

