using System;
using System.Collections.Generic;
using Weather.ViewModels;
using Weather.Views;
using Xamarin.Forms;

namespace Weather
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CityListPage), typeof(CityListPage));
            Routing.RegisterRoute(nameof(CityDetailPage), typeof(CityDetailPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
