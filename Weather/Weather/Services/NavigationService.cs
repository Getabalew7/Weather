using System;
using System.Threading.Tasks;
using Weather.Views;
using Xamarin.Forms;

namespace Weather.Services
{
    public class NavigationService : INavigationService
    {
        public Task GotoCityDetails(string CityName)
        {
            try
            {
                var navState = new ShellNavigationState($"{nameof(CityDetailPage)}?CityName={CityName}");
                return Shell.Current.GoToAsync(navState);

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
           
        }
    }
}
