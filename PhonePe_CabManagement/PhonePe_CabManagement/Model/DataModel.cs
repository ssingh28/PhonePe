using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.Model
{
    public class DataModel
    {
        private static Dictionary<string, Cab> cabTable = new Dictionary<string, Cab>();
        private static HashSet<string> city = new HashSet<string>();
        private static Dictionary<string, List<Cab>> cityToCabMapper = new Dictionary<string, List<Cab>>();
        private static Dictionary<string, List<CabStatus>> cabHistory = new Dictionary<string, List<CabStatus>>();
        public void RegisterCab(string cabId, string cityName)
        {
            if (cabTable.ContainsKey(cabId))
            {
                Console.WriteLine($"The cabid:{cabId} is already registerd!");
                return;
            }
            else if (!city.Contains(cityName))
            {
                Console.WriteLine($"The city name:{cityName} is not onboarded!");
                return;
            }
            else
            {
                Cab cabObj = new Cab(cabId, cityName);
                cabTable.Add(cabId, cabObj);

                if (!cityToCabMapper.ContainsKey(cityName))
                {
                    List<Cab> cabList = new List<Cab>();
                    cabList.Add(cabObj);
                    cityToCabMapper.Add(cityName, cabList);
                }
                else
                {
                    List<Cab> cabList = cityToCabMapper[cityName];
                    cabList.Add(cabObj);
                    List<Cab> sortedCabList = cabList.OrderBy(x => x.IdleSince).ToList();
                    cityToCabMapper[cityName] = sortedCabList;
                }

                if (!cabHistory.ContainsKey(cabId))
                {
                    List<CabStatus> statusList = new List<CabStatus>();
                    statusList.Add(CabStatus.IDLE);
                    cabHistory.Add(cabId, statusList);
                }
                else
                {
                    List<CabStatus> statusList = cabHistory[cabId];
                    statusList.Add(CabStatus.IDLE);
                    cabHistory[cabId] = statusList;
                }
                Console.WriteLine("Cab registered successfully!");
            }
        }

        public void ChangeCurrentCity(string cabId, string newCityName)
        {
            if (!cabTable.ContainsKey(cabId))
            {
                Console.WriteLine($"The cabid:{cabId} is not registerd!");
                return;
            }
            else if (!city.Contains(newCityName))
            {
                Console.WriteLine($"The city name:{newCityName} is not onboarded!");
                return;
            }
            else
            {
                Cab cabObj = cabTable[cabId];
                cabObj.CityName = newCityName;
                cabTable[cabId] = cabObj;
                Console.WriteLine("New City updated successfully!");
            }
        }

        public void OnboardCity(string cityName)
        {
            if (city.Contains(cityName))
            {
                Console.WriteLine($"The city name:{cityName} is already onboarded!");
                return;
            }
            else
            {
                city.Add(cityName);
                Console.WriteLine("New City onboarded successfully!");
            }
        }

        public void ChangeCabStatus(string cabId, CabStatus cabStatus)
        {
            if (!cabTable.ContainsKey(cabId))
            {
                Console.WriteLine($"The cabid:{cabId} is not registerd!");
                return;
            }
            else
            {
                Cab cabObj = cabTable[cabId];
                cabObj.CabStatus = cabStatus;
                cabTable[cabId] = cabObj;

                if (cabHistory.ContainsKey(cabId))
                {
                    List<CabStatus> statusList = cabHistory[cabId];
                    statusList.Add(cabStatus);
                    cabHistory[cabId] = statusList;
                }
                else
                {
                    List<CabStatus> statusList = new List<CabStatus>();
                    statusList.Add(cabStatus);
                    cabHistory.Add(cabId, statusList);
                }
            }
        }

        public void BookCab(string cityName)
        {
            if (!city.Contains(cityName))
            {
                Console.WriteLine($"The city name:{cityName} is not onboarded!");
                return;
            }
            else
            {
                List<Cab> cabList = cityToCabMapper[cityName];
                if(cabList == null || cabList.Count == 0)
                {
                    Console.WriteLine("No cabs available righ now");
                    return;
                }
                else
                {
                    Cab availableCab = cabList.ElementAt(0);
                    availableCab.IdleSince = null;
                    availableCab.TimeOfBooking = DateTime.Now;
                    availableCab.CityName = null;
                    ChangeCabStatus(availableCab.CabId, CabStatus.ON_TRIP);

                    cabList.RemoveAt(0);
                    List<Cab> sortedCabList = cabList.OrderBy(x => x.IdleSince).ToList();
                    cityToCabMapper[cityName] = sortedCabList;
                    Console.WriteLine($"The cab: {availableCab.CabId} has been assigned!!");
                }
            }
        }

        public void GetCabHistory(string cabId)
        {
            if (!cabTable.ContainsKey(cabId))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("INVALID INPUT.Cab Id!!");
            }
            else
            {
                List<CabStatus> statusList = cabHistory[cabId];
                foreach(CabStatus status in statusList)
                {
                    Console.WriteLine(status.ToString());
                }
            }
        }
    }
}
