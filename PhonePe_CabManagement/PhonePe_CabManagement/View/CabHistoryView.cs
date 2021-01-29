using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class CabHistoryView:IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the cab id");
            string cabId = Console.ReadLine();
            if(string.IsNullOrEmpty(cabId) || string.IsNullOrWhiteSpace(cabId))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. Cab Id!!");
                return;
            }

            new CabHistoryController().GetCabHistory(cabId);
        }
    }
}
