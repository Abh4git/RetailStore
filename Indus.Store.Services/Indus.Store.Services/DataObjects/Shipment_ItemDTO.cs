using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class Shipment_ItemDTO
    {
        public int shipment_Item_id
        {
            get;
            set;
        }

        public int order_Item_id
        {
            get;
            set;
        }


        //Navigation Properties
        public Order_ItemDTO Order_Item
        {
            get;
            set;
        }
        public ShipmentDTO Shipment
        {
            get;
            set;
        }


    }
}
