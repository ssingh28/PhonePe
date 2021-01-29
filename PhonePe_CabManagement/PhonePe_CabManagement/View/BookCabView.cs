using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class BookCabView : IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("Enter city where you want cab");
            string cityName = Console.ReadLine();

            if (string.IsNullOrEmpty(cityName) || string.IsNullOrWhiteSpace(cityName))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. CityName!!");
                return;
            }

            else
            {
                new BookCabController().BookCab(cityName.Trim().ToLower());
            }
        }
    }
}
