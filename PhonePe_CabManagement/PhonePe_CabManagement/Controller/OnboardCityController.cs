using PhonePe_CabManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.Controller
{
    public class OnboardCityController
    {
        public void OnboardCity(string cityName)
        {
            new DataModel().OnboardCity(cityName);
        }
    }
}
