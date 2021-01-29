using PhonePe_CabManagement.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            MainView mainViewObj = new MainView();
            //int retry = 0;
            string input;
            int option;
            ContextView contextViewObj;

            while (true)
            {
                Console.WriteLine("\n\n");
                mainViewObj.DisplayMainMenu();
                input = Console.ReadLine();
                Int32.TryParse(input, out option);
                if (option == 9)
                    break;

                switch (option)
                {
                    case 1:
                        contextViewObj = new ContextView(new RegisterCabView()); contextViewObj.ExecuteOrder();
                        break;

                    case 2:
                        contextViewObj = new ContextView(new OnboardCityView()); contextViewObj.ExecuteOrder();
                        break;

                    case 3:
                        contextViewObj = new ContextView(new ChangeCurrentCityView()); contextViewObj.ExecuteOrder();
                        break;

                    case 4:
                        contextViewObj = new ContextView(new ChangeCabStatusView()); contextViewObj.ExecuteOrder();
                        break;

                    case 5:
                        contextViewObj = new ContextView(new BookCabView()); contextViewObj.ExecuteOrder();
                        break;

                    default: break;
                }
            }
        }
    }
}
