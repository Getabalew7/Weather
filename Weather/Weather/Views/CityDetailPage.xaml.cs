using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CityDetailPage : ContentPage
    {
        private CityDetailsViewModel viewModel = new CityDetailsViewModel();
   
        public CityDetailPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
 

}