using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class RegisterCabView : IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("Please enter the cab id: ");
            string cabId = Console.ReadLine();
            if(string.IsNullOrEmpty(cabId) || string.IsNullOrWhiteSpace(cabId))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT.CabId!!");
                return;
            }
            Console.WriteLine("Please enter the city name: ");
            string cityName = Console.ReadLine();
            if (string.IsNullOrEmpty(cityName) || string.IsNullOrWhiteSpace(cityName))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT.City name!!");
                return;
            }

            new RegisterCabController().RegisterCab(cabId.Trim().ToLower(), cityName.Trim().ToLower());
        }
    }
}
