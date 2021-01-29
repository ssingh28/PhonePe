using PhonePe_CabManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.Controller
{
    public class ChangeCurrentCityController
    {
        public void ChangeCurrentCity(string cabId, string newCityName)
        {
            new DataModel().ChangeCurrentCity(cabId, newCityName);
        }
    }
}
