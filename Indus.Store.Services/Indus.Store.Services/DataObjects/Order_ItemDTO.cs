using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class Order_ItemDTO
    {
        public int order_id
        {
            get;
            set;
        }

        public int order_item_id
        {
            get;
            set;
        }

        public int order_item_price
        {
            get;
            set;
        }

        public int order_item_quantity
        {
            get;
            set;
        }

        public int order_item_status_code
        {
            get;
            set;
        }



        public String other_order_item_details
        {
            get;
            set;
        }

        public int product_id
        {
            get;
            set;
        }


        public String RMA_issued_by
        {
            get;
            set;
        }

        public DateTime RMA_issued_date
        {
            get;
            set;
        }

        public int RMA_number
        {
            get;
            set;
        }

        //Navigation Properties
        public OrderDTO Order
        {
            get;
            set;
        }
        public Ref_Order_Item_StatusDTO Ref_Order_Item_Status
        {
            get;
            set;
        }
    }
}
