using PhonePe_CabManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.Controller
{
    public class ChangeCabStatusController
    {
        public void ChangeCabStatus(string cabid, CabStatus cabStatusEnum)
        {
            new DataModel().ChangeCabStatus(cabid, cabStatusEnum);
        }
    }
}
