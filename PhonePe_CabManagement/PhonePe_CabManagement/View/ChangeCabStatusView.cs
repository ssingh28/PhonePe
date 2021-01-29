using PhonePe_CabManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class ChangeCabStatusView : IOrder
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Please enter the cabid");
            string cabId = Console.ReadLine();
            if (string.IsNullOrEmpty(cabId) || string.IsNullOrWhiteSpace(cabId))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. CabId!!");
                return;
            }

            Console.WriteLine("Please enter the new cab status(0 = IDLE, 1 = ON TRIP)");
            string cabStatusInput = Console.ReadLine();
            if (string.IsNullOrEmpty(cabStatusInput) || string.IsNullOrWhiteSpace(cabStatusInput))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT. Cab Status!!");
                return;
            }
            int option;
            CabStatus cabStatusEnum;
            Int32.TryParse(cabStatusInput, out option);
            if(option == 0)
            {
                cabStatusEnum = CabStatus.IDLE;
            }
            else if(option == 1)
            {
                cabStatusEnum = CabStatus.ON_TRIP;
            }
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT.Cab Status!!");
                return;
            }
            new ChangeCabStatusController().ChangeCabStatus(cabId.Trim().ToLower(), cabStatusEnum);
        }
    }
}
