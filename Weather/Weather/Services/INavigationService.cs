using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Services
{
   public interface INavigationService
    {
        Task GotoCityDetails(string cityName);
    }
}
