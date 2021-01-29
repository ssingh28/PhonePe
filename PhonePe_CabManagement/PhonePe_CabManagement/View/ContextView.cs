using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePe_CabManagement.View
{
    public class ContextView
    {
        private IOrder order;

        public ContextView(IOrder order)
        {
            this.order = order;
        }

        public void ExecuteOrder()
        {
            order.ExecuteOrder();
        }
    }
}
