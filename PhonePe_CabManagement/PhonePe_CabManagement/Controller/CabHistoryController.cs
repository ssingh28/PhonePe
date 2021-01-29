using PhonePe_CabManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.Controller
{
    public class CabHistoryController
    {
        public void GetCabHistory(string cabId)
        {
            new DataModel().GetCabHistory(cabId);
        }
    }
}
