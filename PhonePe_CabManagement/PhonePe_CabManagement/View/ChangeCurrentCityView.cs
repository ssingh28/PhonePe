using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class ChangeCurrentCityView : IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("Enter the cabid for which you would like to change the city");
            string cabId = Console.ReadLine();
            if (string.IsNullOrEmpty(cabId) || string.IsNullOrWhiteSpace(cabId))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. Cabid!!");
                return;
            }
            Console.WriteLine("Enter the new city name");
            string newCityName = Console.ReadLine();
            if (string.IsNullOrEmpty(newCityName) || string.IsNullOrWhiteSpace(newCityName))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. City name!!");
                return;
            }

            new ChangeCurrentCityController().ChangeCurrentCity(cabId, newCityName);
        }
    }
}
