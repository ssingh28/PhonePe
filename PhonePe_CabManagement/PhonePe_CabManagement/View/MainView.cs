using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class MainView
    {
        public void DisplayMainMenu()
        {
            Console.WriteLine("Enter the option for the task you want to perform");
            Console.WriteLine("=================================================");
            Console.WriteLine("Press 1 to register cab");
            Console.WriteLine("Press 2 to onboard a city");
            Console.WriteLine("Press 3 to change current city(location) of a cab");
            Console.WriteLine("Press 4 to change state of a cab");
            Console.WriteLine("Press 5 to book a cab");
            Console.WriteLine("Press 6 to get idle time for a cab");
            Console.WriteLine("Press 7 to get history of a cab");
            Console.WriteLine("Press 8 to get cities where the demand for cabs is high and the time when the demand is highest");
            Console.WriteLine("Press 9 to exit");
        }
    }
}
