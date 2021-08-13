using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.ObjectModel;

namespace Weather.Models
{
    public class City : ObservableObject
    {
       public string Name { get; set; }
        public string Country { get; set; }
        private double? _temprature;
        public double? Temprature {
            get => _temprature;
            set => SetProperty(ref _temprature, value);
        }
        private double? _pressure;
        public double? Pressure {
            get => _pressure;
            set => SetProperty(ref _pressure, value);
        }
        private double? _humidity;
        public double? Humidity {
            get => _pressure;
            set => SetProperty(ref _humidity, value);
        }
        private double? _wind;
        public double? Wind {
            get => _wind;
            set => SetProperty(ref _wind, value);
        }
        public bool isSelected { get; set; }


    }
}