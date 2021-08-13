using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Weather.Models;
using Weather.Services;
using Weather.Views;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Weather.ViewModels
{
   public class CityListViewModel : ObservableObject
    {
        public List<City> cities { get; } = new List<City>()
           {
               new City{Name="Addis ababa", Country="ETH",isSelected=true},
               new City{Name="Awassa", Country="ETH", isSelected=false},
               new City{Name="Shashemene", Country="ETH", isSelected=false},
               new City{Name= "Adama" , Country ="ETH", isSelected=false}
           };
        private City _selectedCity;
       public City SelectedCity 
        {
            get => _selectedCity;
            set => SetProperty(ref _selectedCity, value);
        }
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }
        public ICommand RefreshCommand { get; }

        public ICommand SelecteCityCommand { get; }
        public CityListViewModel()
        {
            RefreshCommand = new Command(RefreshExecute);
            SelecteCityCommand = new Command(SelectCityExecute);
        }

        private async void RefreshExecute()
        {
            // Debug.WriteLine("Refresh execute");
            try
            {
                IsRefreshing = true;
                var weatherService = DependencyService.Resolve<IWeatherService>();
                foreach (var city in cities)
                {
                    var weatherData = await weatherService.GetWeatherForCity(city.Name);
                    city.Temprature = Convert.ToDouble(weatherData.main.temp.ToString("0.00"));
                    city.Pressure = weatherData.main.pressure;
                    city.Humidity = weatherData.main.humidity;
                    city.Wind = weatherData.wind.speed;
                    Debug.WriteLine($"Weather data for {city.Name} is recived  temprature {city.Temprature}");
                }
            }
            finally
            {
                IsRefreshing = false;
            }
        }

        public async void SelectCityExecute()
        {
           Debug.WriteLine($"Select city execute:{SelectedCity?.Name}");
           await DependencyService.Resolve<INavigationService>().GotoCityDetails(SelectedCity?.Name);
        }

    }
 
} 
