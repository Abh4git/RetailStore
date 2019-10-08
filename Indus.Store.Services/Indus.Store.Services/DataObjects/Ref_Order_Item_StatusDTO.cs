using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class Ref_Order_Item_StatusDTO
    {
        public int order_item_status_code
        {
            get;
            set;
        }

        public string order_item_status_description
        {
            get;
            set;
        }
    }
}
