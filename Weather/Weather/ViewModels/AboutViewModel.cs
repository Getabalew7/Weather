using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    class AboutViewModel :ObservableObject
    {
        public string _aboutMe;
        public string AboutMe {
            get => _aboutMe;
            set => SetProperty(ref _aboutMe, value);
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _query;
        public ICommand openWebCommand { get; }
        public AboutViewModel()
        {
            openWebCommand = new Command(openWebCommandExcute);
            string Title = "About Page";
            _name = "My Name is Getabalew";
            _aboutMe = "This appp is developed during a Xamarin Workshop given by a Microfost Guy called Alexey";
        }

        private async void openWebCommandExcute(object obj)
        {
            try
            {
                await Shell.Current.GoToAsync("https://aka.ms/xamarin-quickstart");
            }
            catch(Exception e)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
