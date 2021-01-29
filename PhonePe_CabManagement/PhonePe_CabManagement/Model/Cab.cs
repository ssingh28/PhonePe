using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement
{
    public enum CabStatus {IDLE, ON_TRIP}

    public class Cab
    {
        private string cabId;
        private string cityName;
        private CabStatus cabStatus;
        private DateTime ? timeOfBooking;
        private DateTime ? idleSince;

        public Cab(string cabId, string cityName)
        {
            this.cabId = cabId;
            this.cityName = cityName;
            cabStatus = CabStatus.IDLE;
            timeOfBooking = null;
            idleSince = System.DateTime.Now;
        }

        public string CabId { get => cabId; set => cabId = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public CabStatus CabStatus { get => cabStatus; set => cabStatus = value; }
        public DateTime? TimeOfBooking { get => timeOfBooking; set => timeOfBooking = value; }
        public DateTime? IdleSince { get => idleSince; set => idleSince = value; }
    }
}
