using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class OnboardCityView : IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("Enter City you would like to onboard");
            string cityName = Console.ReadLine();
            if(string.IsNullOrEmpty(cityName) || string.IsNullOrWhiteSpace(cityName))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT.City name!!");
                return;
            }
            new OnboardCityController().OnboardCity(cityName.Trim().ToLower());
        }
    }
}
