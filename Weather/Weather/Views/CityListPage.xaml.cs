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
    public partial class CityListPage : ContentPage
    {
        private CityListViewModel viewModel= new  CityListViewModel();
        public CityListPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.RefreshCommand.Execute(null);
        }
    }
    public class CityDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate CurrentTemplate { get; set; }
        public CityDataTemplateSelector()
        {
            //faultTemplate = new DataTemplate(typeof(TextCell));
            //urrentTemplate = new DataTemplate(typeof(ImageCell));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var city = item as City;
            return city.isSelected ? CurrentTemplate : DefaultTemplate;
        }
    }
}