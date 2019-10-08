using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class OrderDTO
    {
        public int customer_id
        {
            get;
            set;
        }



        public System.DateTime date_order_placed
        {
            get;
            set;
        }

        public string order_details
        {
            get;
            set;
        }

        public int order_id
        {
            get;
            set;
        }

        public int order_status_code
        {
            get;
            set;
        }

        //Navigation Properties
        public CustomerDTO Customer
        {
            get;
            set;
        }

        public Ref_Order_StatusDTO Ref_Order_Status
        {
            get;
            set;
        }

        public ICollection<Order_ItemDTO> Order_Items
        { get; set; }

        public ICollection<ShipmentDTO> Shipments
        { get; set; }

    }
}
