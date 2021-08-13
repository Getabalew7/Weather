using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Weather.Models;
using Weather.Services;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    [QueryProperty(nameof(CityName), nameof(CityName))]
    class CityDetailsViewModel :ObservableObject
    {
        public string _cityName;
        public string CityName {
                get =>_cityName;
                set
            {
                    if(SetProperty(ref _cityName, value))
                        {
                    RefreshCommand.Execute(null);
                        }
                }
            }
        private DateTime _dateTime;
        public DateTime DateTime {
            get => _dateTime;
            set => SetProperty(ref _dateTime, value);
        }
        private City _selectedCity;
        public City SelectedCity {
            get =>_selectedCity;
            set => SetProperty(ref _selectedCity, value);
        }
        private bool _isNotLoading;
        public bool IsNotLoading {
            get => _isNotLoading;
            set => SetProperty(ref _isNotLoading, value);
        }
        public ICommand RefreshCommand;
        public CityDetailsViewModel()
        {
            RefreshCommand = new Command(RefreshExceute);
            _dateTime = DateTime.Now;
           
        }

        public async void RefreshExceute()
        {
            var weatherService = DependencyService.Resolve<IWeatherService>();
            var weatherData = await weatherService.GetWeatherForCity(CityName);

            var city = new City{
                Name = CityName,
                Temprature = Convert.ToDouble(weatherData.main.temp.ToString("0.00")),
                Pressure = weatherData.main.pressure,
                Humidity = weatherData.main.humidity,
                Wind = weatherData.wind.speed
            };
            SelectedCity = city;
            
            
            //Debug.WriteLine("city recived");
        }
    }
}
